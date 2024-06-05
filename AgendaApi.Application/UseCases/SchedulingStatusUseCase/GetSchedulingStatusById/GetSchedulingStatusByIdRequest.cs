using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.GetSchedulingStatusById
{
    public sealed record GetSchedulingStatusByIdRequest(Guid id)
        : IRequest<GetSchedulingStatusByIdResponse>;
}
