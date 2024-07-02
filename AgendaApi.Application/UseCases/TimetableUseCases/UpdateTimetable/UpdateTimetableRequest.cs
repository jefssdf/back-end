using MediatR;

namespace AgendaApi.Application.UseCases.TimetableUseCases.UpdateTimetable
{
    public sealed record UpdateTimetableRequest(
            Guid id, 
            TimeOnly startTime, 
            TimeOnly endTime, 
            Guid legalEntityId, 
            int weekDayId)
            : IRequest<UpdateTimetableResponse>;
}
