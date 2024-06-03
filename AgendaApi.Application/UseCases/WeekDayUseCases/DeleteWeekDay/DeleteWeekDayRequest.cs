using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.DeleteWeekDay
{
    public sealed record DeleteWeekDayRequest(int id) 
        : IRequest<DeleteWeekDayResponse>;
}
