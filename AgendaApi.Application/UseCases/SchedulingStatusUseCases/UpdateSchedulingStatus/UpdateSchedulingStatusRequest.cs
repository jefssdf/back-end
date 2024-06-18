using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.UpdateSchedulingStatus
{
    public sealed record UpdateSchedulingStatusRequest(
                int schedulingStatusId, 
                string statusName)
                    : IRequest<UpdateSchedulingStatusResponse>;
}
