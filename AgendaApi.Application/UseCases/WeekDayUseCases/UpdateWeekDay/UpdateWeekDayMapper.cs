using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.UpdateWeekDay
{
    public sealed class UpdateWeekDayMapper : Profile
    {
        public UpdateWeekDayMapper() 
        {
            CreateMap<UpdateWeekDayRequest, WeekDay>();
            CreateMap<WeekDay, UpdateWeekDayResponse>();
        }
    }
}
