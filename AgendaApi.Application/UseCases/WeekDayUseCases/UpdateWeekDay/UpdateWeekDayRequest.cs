using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.UpdateWeekDay
{
    public sealed record UpdateWeekDayRequest(int id,
        string name) 
        : IRequest<UpdateWeekDayResponse>;
}
