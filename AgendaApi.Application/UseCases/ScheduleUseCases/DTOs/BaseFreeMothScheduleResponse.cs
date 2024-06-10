namespace AgendaApi.Application.UseCases.ScheduleUseCases.DTOs
{
    public abstract record BaseFreeMothScheduleResponse
    {
        public string AvailableTime { get; set; }
        public int WeekDayId { get; set; }
    }
}
