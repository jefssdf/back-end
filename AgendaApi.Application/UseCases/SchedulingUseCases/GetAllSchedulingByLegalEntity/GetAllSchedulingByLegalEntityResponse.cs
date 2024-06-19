using AgendaApi.Application.UseCases.SchedulingUseCases.DTOs;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetSchedulingById;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByLegalEntity
{
    public sealed record GetAllSchedulingByLegalEntityResponse
    {
        public GetSchedulingByIdResponse schedulingByIdResponse { get; set; }
        public string? naturalPersonName { get; set; }
        public string? naturalPersonPhone { get; set; }
        public string? serviceName { get; set; }
    }
}
