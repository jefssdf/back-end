using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetAllWeekDay
{
    public sealed class GetAllWeekDayMapper : Profile
    {
        public GetAllWeekDayMapper() 
        {
            CreateMap<WeekDay, GetAllWeekDayResponse>();
            CreateMap<AvailableTimeDTO, FreeSchedulingResponse>()
                .ForMember(dest => dest.AvailableTime,
                opt => opt.MapFrom(src =>  src.StartTime.ToString("HH:mm")));
        }
    }
}
