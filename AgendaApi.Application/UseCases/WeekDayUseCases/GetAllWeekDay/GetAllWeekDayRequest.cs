using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay
{
    public sealed record GetAllWeekDayRequest(Guid legalEntityId) 
        : IRequest<List<GetAllWeekDayResponse>>;
    
}
