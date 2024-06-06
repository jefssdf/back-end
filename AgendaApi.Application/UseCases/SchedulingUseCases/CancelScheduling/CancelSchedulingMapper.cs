using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.DeleteScheduling
{
    public sealed class CancelSchedulingMapper : Profile
    {
        public CancelSchedulingMapper() 
        {
            CreateMap<CancelSchedulingRequest, Cancellation>();
            CreateMap<Scheduling, CancelSchedulingResponse>();
        }
    }
}
