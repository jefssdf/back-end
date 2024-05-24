using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.GetServiceById
{
    public sealed record GetServiceByIdRequest(Guid id) 
        : IRequest<GetServiceByIdResponse>;
}
