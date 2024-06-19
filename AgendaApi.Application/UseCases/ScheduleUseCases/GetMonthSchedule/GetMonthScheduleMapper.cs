using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling;
using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;
using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetMonthSchedule
{
    public sealed class GetMonthScheduleMapper : Profile
    {
        public GetMonthScheduleMapper() 
        {
            CreateMap<Scheduling, GetAllSchedulingResponse>();
            CreateMap<Timetable, GetAllTimetablesResponse>();
        }
    }
}
