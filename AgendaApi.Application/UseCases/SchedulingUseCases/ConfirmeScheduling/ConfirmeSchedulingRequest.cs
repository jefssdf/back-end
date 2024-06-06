using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public sealed record ConfirmeSchedulingRequest(Guid id)
        : IRequest<ConfirmeSchedulingResponse>;
}
