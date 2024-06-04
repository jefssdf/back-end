namespace AgendaApi.Application.UseCases.WeekDayUseCases.DTOs
{
    public abstract record BaseFreeSchedulingResponse
    {
        public string AvailableTime { get; set; }
        public int WeekDayId { get; set; }
    }
}
