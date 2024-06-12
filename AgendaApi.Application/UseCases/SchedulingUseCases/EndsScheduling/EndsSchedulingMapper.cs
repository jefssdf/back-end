using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public sealed class EndsSchedulingMapper : Profile
    {
        public EndsSchedulingMapper() 
        {
            CreateMap<Scheduling, EndsSchedulingResponse>();
        }
    }
}
