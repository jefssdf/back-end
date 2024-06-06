using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.UpdateSchedulingStatus
{
    public sealed record UpdateSchedulingStatusRequest(
                int id, 
                string statusName)
                    : IRequest<UpdateSchedulingStatusResponse>;
}
