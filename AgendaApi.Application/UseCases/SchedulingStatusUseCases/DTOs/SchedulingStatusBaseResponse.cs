namespace AgendaApi.Application.UseCases.SchedulingStatusUseCase.DTOs
{
    public abstract record SchedulingStatusBaseResponse
    {
        public Guid SchedulingStatusId { get; set; }
        public string StatusName { get; set; }
    }
}
