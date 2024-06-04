namespace AgendaApi.Application.UseCases.WeekDayUseCases.DTOs
{
    public abstract record BaseAvailableTimeDTO
    {
        public TimeOnly StartTime { get; set; }
        public int WeekDayId { get; set; }
    }
}
