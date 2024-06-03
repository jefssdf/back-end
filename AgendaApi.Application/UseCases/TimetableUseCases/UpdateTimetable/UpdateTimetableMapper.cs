using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.TimetableUseCases.UpdateTimetable
{
    public sealed class UpdateTimetableMapper : Profile
    {
        public UpdateTimetableMapper() 
        {
            CreateMap<UpdateTimetableRequest, Timetable>();
            CreateMap<Timetable, UpdateTimetableResponse>();
        }
    }
}
