using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByNaturalPerson
{
    public sealed record GetAllSchedulingByNaturalPersonRequest(Guid naturalPersonId)
        : IRequest<List<GetAllSchedulingByNaturalPersonResponse>>;
}
