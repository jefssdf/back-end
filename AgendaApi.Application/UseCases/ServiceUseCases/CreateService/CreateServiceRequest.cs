using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.CreateService
{
    public sealed record CreateServiceRequest(
        string name,
        string description,  
        decimal price, 
        Guid legalEntityId)
        : IRequest<CreateServiceResponse>;
}
