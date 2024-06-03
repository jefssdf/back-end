using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCases.GetServiceByLegalEntityId
{
    public sealed record GetServiceByLegalEntityIdRequest(Guid id) 
        : IRequest<List<GetServiceByLegalEntityIdResponse>>
    {
    }
}
