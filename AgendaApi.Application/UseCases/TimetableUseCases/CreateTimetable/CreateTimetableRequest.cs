using AgendaApi.Application.UseCases.TimetableUseCases.DTOs;
using MediatR;
using System.Text.Json.Serialization;

namespace AgendaApi.Application.UseCases.TimetableUseCases.CreateTimetable
{
    public sealed record CreateMultipleTimetableRequest(
        List<CreateTimetableRequest> TimetableRequests)
        : IRequest<List<CreateTimetableResponse>>;
    public sealed record CreateTimetableRequest(
        [property: JsonConverter(typeof(TimeOnlyJsonConverter))] 
        TimeOnly startTime,
        [property: JsonConverter(typeof(TimeOnlyJsonConverter))] 
        TimeOnly endTime,
        Guid legalEntityId,
        int weekDayId)
        : IRequest<CreateTimetableResponse>;
}