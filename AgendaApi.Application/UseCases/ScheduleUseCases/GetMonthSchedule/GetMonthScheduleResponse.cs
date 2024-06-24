using AgendaApi.Application.UseCases.ScheduleUseCases.DTOs;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling;
using AgendaApi.Application.UseCases.ServiceUseCases.GetServiceByLegalEntityId;
using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;
using AgendaApi.Domain.Entities;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetMonthSchedule
{
    public sealed record FreeMonthScheduleResponse : BaseFreeMothScheduleResponse;
    public sealed record GetMonthScheduleResponse
    {
        public List<GetAllSchedulingResponse> Schedulings { get; set; }
        public List<GetAllTimetablesResponse> AvailableTimes { get; set; }
        public List<RequestedInfo> Info { get; set; }
    }

    public sealed record RequestedInfo
    {
        public string ServiceName { get; set; }
        public string ServiceDuration { get; set; }
        public string NaturalPersonName { get; set; }
    }
}
