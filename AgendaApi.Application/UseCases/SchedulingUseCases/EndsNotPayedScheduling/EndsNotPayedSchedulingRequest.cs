using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.EndsNotPayedScheduling
{
    public sealed record EndsNotPayedSchedulingRequest(Guid schedulingId)
        : IRequest<EndsNotPayedSchedulingResponse>;
}
