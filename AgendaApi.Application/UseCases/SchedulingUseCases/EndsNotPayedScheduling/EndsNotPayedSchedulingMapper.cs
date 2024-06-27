using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.EndsNotPayedScheduling
{
    public sealed class EndsNotPayedSchedulingMapper : Profile
    {
        public EndsNotPayedSchedulingMapper() 
        {
            CreateMap<Scheduling, EndsNotPayedSchedulingResponse>();
        }
    }
}
