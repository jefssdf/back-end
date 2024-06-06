using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.UpdateSchedulingStatus
{
    public sealed record UpdateSchedulingStatusRequest(
                Guid id, 
                string statusName)
                    : IRequest<UpdateSchedulingStatusResponse>;
}
