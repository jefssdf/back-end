using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public sealed class EndsPayedSchedulingMapper : Profile
    {
        public EndsPayedSchedulingMapper() 
        {
            CreateMap<Scheduling, EndsPayedSchedulingResponse>();
        }
    }
}
