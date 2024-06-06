using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetSchedulingById
{
    public sealed class GetSchedulingByIdMapper : Profile
    {
        public GetSchedulingByIdMapper() 
        {
            CreateMap<Scheduling, GetSchedulingByIdResponse>();
        }
    }
}
