using AgendaApi.Application.UseCases.SchedulingUseCases.GetSchedulingById;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByNaturalPerson
{
    public sealed record GetAllSchedulingByNaturalPersonResponse
    {
        public GetSchedulingByIdResponse schedulingByIdResponse {  get; set; }
        public string? naturalPersonName { get; set; }
        public string? naturalPersonPhone { get; set; }
        public string? serviceName { get; set; }
    }
}
