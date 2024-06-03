using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;
using AgendaApi.Application.UseCases.WeekDayUseCases.DTOs;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay
{
    public sealed record GetAllWeekDayResponse : WeekDayBaseResponse
    {
        public ICollection<GetAllTimetablesResponse> Timetables { get; set; }
    }
    public sealed record FreeSchedulingResponse : BaseFreeSchedulingResponse;
    public sealed record AvailableTimeDTO : BaseAvailableTimeDTO;
}
