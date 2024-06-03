using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.DeleteWeekDay
{
    public sealed class DeleteWeekDayMapper : Profile
    {
        public DeleteWeekDayMapper() 
        {
            CreateMap<WeekDay, DeleteWeekDayResponse>();
        }
    }
}
