using MediatR;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetMonthSchedule
{
    public sealed record GetMonthScheduleRequest(DateTime date,
        Guid id)
        : IRequest<GetMonthScheduleResponse>;
}
