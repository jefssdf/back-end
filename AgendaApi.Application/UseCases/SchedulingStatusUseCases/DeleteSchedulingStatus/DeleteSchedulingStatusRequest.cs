using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.DeleteSchedulingStatus
{
    public sealed record DeleteSchedulingStatusRequest(int id)
        : IRequest<DeleteSchedulingStatusResponse>;
}
