using AgendaApi.Application.UseCases.ScheduleUseCases.DTOs;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling;
using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetMonthSchedule
{
    public sealed record FreeMonthScheduleResponse : BaseFreeMothScheduleResponse;
    public sealed record GetMonthScheduleResponse
    {
        public List<GetAllSchedulingResponse> Schedulings { get; set; }
        public List<GetAllTimetablesResponse> AvailableTimes { get; set; }
    }
}
