using AgendaApi.Application.UseCases.TimetableUseCases.DTOs;
using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;
using AgendaApi.Application.UseCases.WeekDayUseCases.DTOs;
using AgendaApi.Domain.Entities;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById
{
    public sealed record GetWeekDayByIdResponse : WeekDayBaseResponse
    {
        public ICollection<GetAllTimetablesResponse> Timetables { get; set; }
    }
    public sealed record FreeSchedulingResponseById : BaseFreeSchedulingResponse;
    public sealed record AvailableTimeDTOById : BaseAvailableTimeDTO;
}
