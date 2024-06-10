using AgendaApi.Application.UseCases.ScheduleUseCases.DTOs;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetMonthSchedule
{
    public sealed record FreeMonthScheduleResponse : BaseFreeMothScheduleResponse;
    public sealed record GetMonthScheduleResponse
    {
        public List<GetAllSchedulingResponse> Schedulings { get; set; }
        public List<FreeMonthScheduleResponse> AvailableTimes { get; set; }
    }
}
