using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling
{
    public sealed class GetAllSchedulingMapper : Profile
    {
        public GetAllSchedulingMapper() 
        {
            CreateMap<Scheduling, GetAllSchedulingResponse>();
        }
    }
}
