using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling
{
    public sealed record GetAllSchedulingRequest : IRequest<List<GetAllSchedulingResponse>>;
}
