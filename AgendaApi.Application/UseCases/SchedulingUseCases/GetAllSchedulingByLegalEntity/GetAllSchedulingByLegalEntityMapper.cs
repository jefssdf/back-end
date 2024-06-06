using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByLegalEntity
{
    public sealed class GetAllSchedulingByLegalEntityMapper : Profile
    {
        public GetAllSchedulingByLegalEntityMapper() 
        {
            CreateMap<Scheduling, GetAllSchedulingByLegalEntityResponse>();
        }
    }
}
