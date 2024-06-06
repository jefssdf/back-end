using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public sealed class ConfirmeSchedulingMapper : Profile
    {
        public ConfirmeSchedulingMapper() 
        {
            CreateMap<Scheduling, ConfirmeSchedulingResponse>();
        }
    }
}
