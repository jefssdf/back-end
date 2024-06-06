using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetSchedulingById
{
    public sealed record GetSchedulingByIdRequest(Guid id)
        : IRequest<GetSchedulingByIdResponse>;
}
