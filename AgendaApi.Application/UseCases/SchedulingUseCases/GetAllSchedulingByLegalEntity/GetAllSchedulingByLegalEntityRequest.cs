using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByLegalEntity
{
    public sealed record GetAllSchedulingByLegalEntityRequest(Guid legalEntityId)
        : IRequest<List<GetAllSchedulingByLegalEntityResponse>>
    {
    }
}
