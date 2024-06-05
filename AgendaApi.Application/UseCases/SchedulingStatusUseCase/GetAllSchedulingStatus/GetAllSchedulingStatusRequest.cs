using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.GetAllSchedulingStatus
{
    public sealed record GetAllSchedulingStatusRequest 
        : IRequest<List<GetAllSchedulingStatusResponse>>;
}
