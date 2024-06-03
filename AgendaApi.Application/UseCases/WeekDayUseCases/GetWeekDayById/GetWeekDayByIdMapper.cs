using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;
using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById
{
    public sealed class GetWeekDayByIdMapper : Profile
    {
        public GetWeekDayByIdMapper() 
        {
            CreateMap<WeekDay, GetWeekDayByIdResponse>();
            CreateMap<AvailableTimeDTOById, FreeSchedulingResponseById>()
                .ForMember(dest => dest.AvailableTime,
                opt => opt.MapFrom(src => src.StartTime.ToString("HH:mm")));
        }
    }
}
