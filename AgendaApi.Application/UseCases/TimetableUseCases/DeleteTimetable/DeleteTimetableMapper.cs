using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.TimetableUseCases.DeleteTimetable
{
    public sealed class DeleteTimetableMapper : Profile
    {
        public DeleteTimetableMapper() 
        {
            CreateMap<Timetable, DeleteTimetableResponse>();
        }
    }
}
