using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public sealed record EndsPayedSchedulingRequest(Guid schedulingId)
        : IRequest<EndsPayedSchedulingResponse>;
}
