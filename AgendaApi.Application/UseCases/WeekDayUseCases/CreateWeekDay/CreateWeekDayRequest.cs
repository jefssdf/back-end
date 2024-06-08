using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.CreateWeekDay
{
    public sealed record CreateWeekDayRequest(
        int WeekDayId, 
        string name) 
        : IRequest<CreateWeekDayResponse>;
}
