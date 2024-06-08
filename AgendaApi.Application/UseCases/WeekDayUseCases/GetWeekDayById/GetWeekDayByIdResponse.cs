using AgendaApi.Application.UseCases.SchedulingUseCases.DTOs;
using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;
using AgendaApi.Application.UseCases.WeekDayUseCases.DTOs;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById
{
    public sealed record GetWeekDayByIdResponse : WeekDayBaseResponse
    {
        public ICollection<GetAllTimetablesResponse> Timetables { get; set; }
    }
    public sealed record FreeSchedulingResponseById : BaseFreeSchedulingResponse;
    public sealed record AvailableTimeDTOById : BaseAvailableTimeDTO;

    public sealed record GetWeekDayByIdResponseComplete
    {
        public List<AvailableTimeDTOById> availableTimes { get; set; }
        public List<SchedulingBaseResponse> schedulings { get; set; }
        public int totalSchedulings { get; set; }
    }
                    
}
