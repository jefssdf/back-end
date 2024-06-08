using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.CreateService
{
    public sealed record CreateServiceRequest(
        string name,
        string description,
        string duration,
        decimal price, 
        Guid legalEntityId)
        : IRequest<CreateServiceResponse>;
}
