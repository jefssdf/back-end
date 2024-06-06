using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.DeleteScheduling
{
    public sealed record CancelSchedulingRequest(
        Guid schedulingId,
        Guid owner)
        : IRequest<CancelSchedulingResponse>;
}