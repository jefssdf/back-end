using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.CreateScheduling
{
    public sealed class CreateSchedulingMapper : Profile
    {
        public CreateSchedulingMapper()
        {
            CreateMap<CreateSchedulingRequest, Scheduling>();
            CreateMap<Scheduling, CreateSchedulingResponse>();
        }
    }
}
