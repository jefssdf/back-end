using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;
using AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.DTOs
{
    public abstract record BaseFreeMothScheduleResponse
    {
        public GetAllTimetablesResponse AvailableTime { get; set; }
    }
}
