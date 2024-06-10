using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling;
using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetMonthSchedule
{
    public sealed class GetMonthScheduleMapper : Profile
    {
        public GetMonthScheduleMapper() 
        {
            CreateMap<Scheduling, GetAllSchedulingResponse>();
        }
    }
}
