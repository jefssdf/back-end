using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay
{
    public sealed record GetAllWeekDayRequest(DateTime date) 
        : IRequest<GetAllWeekDayResponse>;
    
}
