using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByLegalEntity
{
    public sealed record GetAllSchedulingByLegalEntityRequest(Guid id)
        : IRequest<List<GetAllSchedulingByLegalEntityResponse>>
    {
    }
}
