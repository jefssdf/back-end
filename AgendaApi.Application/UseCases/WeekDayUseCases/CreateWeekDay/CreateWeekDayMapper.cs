using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.CreateWeekDay
{
    public sealed class CreateWeekDayMapper : Profile
    {
        public CreateWeekDayMapper() 
        {
            CreateMap<CreateWeekDayRequest, WeekDay>();
            CreateMap<WeekDay, CreateWeekDayResponse>();
        }
    }
}
