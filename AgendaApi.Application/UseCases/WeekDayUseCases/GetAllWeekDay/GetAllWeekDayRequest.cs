using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay
{
    public sealed record GetAllWeekDayRequest 
        : IRequest<List<GetAllWeekDayResponse>>;
    
}
