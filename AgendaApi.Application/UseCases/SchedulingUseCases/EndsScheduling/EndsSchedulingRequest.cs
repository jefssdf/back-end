using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public sealed record EndsSchedulingRequest(Guid schedulingId)
        : IRequest<EndsSchedulingResponse>;
}
