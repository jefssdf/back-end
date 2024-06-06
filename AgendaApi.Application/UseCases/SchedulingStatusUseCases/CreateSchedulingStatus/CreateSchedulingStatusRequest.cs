using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.CreateSchedulingStatus
{
    public sealed record CreateSchedulingStatusRequest(string statusName)
        : IRequest<CreateSchedulingStatusResponse>;
}
