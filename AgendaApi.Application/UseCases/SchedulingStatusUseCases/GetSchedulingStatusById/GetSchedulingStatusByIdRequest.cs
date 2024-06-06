using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.GetSchedulingStatusById
{
    public sealed record GetSchedulingStatusByIdRequest(int id)
        : IRequest<GetSchedulingStatusByIdResponse>;
}
