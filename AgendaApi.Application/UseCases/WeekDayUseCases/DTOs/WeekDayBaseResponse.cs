using AgendaApi.Domain.Entities;
using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.DTOs
{
    public abstract record WeekDayBaseResponse
    {
        public int WeekDayId { get; set; }
        public string Name { get; set; }
    }
    public abstract record BaseFreeSchedulingResponse
    {
        public string AvailableTime { get; set; }
        public int WeekDayId { get; set; }
    }
    public abstract record BaseAvailableTimeDTO
    {
        public TimeOnly StartTime { get; set; }
        public int WeekDayId { get; set; }
    }
}
