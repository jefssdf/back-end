using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.DeleteService
{
    public sealed record DeleteServiceRequest(
        Guid id) 
        : IRequest<DeleteServiceResponse>;
}
