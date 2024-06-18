using AgendaApi.Application.UseCases.SchedulingUseCases.GetSchedulingById;
using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByNaturalPerson
{
    public sealed class GetAllSchedulingByNaturalPersonMapper : Profile
    {
        public GetAllSchedulingByNaturalPersonMapper() 
        {
            CreateMap<Scheduling, GetSchedulingByIdResponse>();
        }
    }
}
