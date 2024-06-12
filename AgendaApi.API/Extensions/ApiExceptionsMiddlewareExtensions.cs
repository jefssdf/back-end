using AgendaApi.Application.Shared.Exceptions;
using AgendaApi.Application.Shared.Exceptions.ErrorDTO;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;

namespace AgendaApi.API.Extensions
{
    public static class ApiExceptionsMiddlewareExtensions
    {
        public static void ConfigureExceptionHandler(this IApplicationBuilder app) 
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    context.Response.ContentType = "application/json";

                    if (contextFeature != null) 
                    {
                        switch (contextFeature.Error)
                        {
                            case NotFoundException _:
                                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                                break;
                            case BadRequestException _:
                                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                                break;
                            case UnauthorizedException _:
                                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                                break;
                            default:
                                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                                break;
                        }
                        await context.Response.WriteAsync(new ErrorDetails
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = contextFeature.Error.Message,
                            Trace = contextFeature.Error.StackTrace
                        }.ToString());
                    }
                });
            });
        }
    }
}
