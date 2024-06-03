using AgendaApi.Domain.Entities;
using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.CreateWeekDay
{
    public sealed record CreateWeekDayRequest(
        int weekDayId, 
        string name) 
        : IRequest<CreateWeekDayResponse>;
}
