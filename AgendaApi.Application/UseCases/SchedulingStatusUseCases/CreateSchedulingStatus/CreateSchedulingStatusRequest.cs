using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.CreateSchedulingStatus
{
    public sealed record CreateSchedulingStatusRequest(
        int SchedulingStatusId,
        string statusName)
        : IRequest<CreateSchedulingStatusResponse>;
}
