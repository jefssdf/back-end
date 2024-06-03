using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.TimetableUseCases.CreateTimetable
{
    public sealed class CreateTimetableMapper : Profile
    {
        public CreateTimetableMapper() 
        {
            CreateMap<CreateTimetableRequest, Timetable>();
            CreateMap<Timetable, CreateTimetableResponse>();
        }
    }
}
