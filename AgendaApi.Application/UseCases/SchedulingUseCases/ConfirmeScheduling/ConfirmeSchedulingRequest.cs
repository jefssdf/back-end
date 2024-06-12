using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public sealed record ConfirmeSchedulingRequest(Guid schedulingId)
        : IRequest<ConfirmeSchedulingResponse>;
}
