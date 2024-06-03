using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables
{
    public sealed class GetAllTimetablesMapper : Profile
    {
        public GetAllTimetablesMapper() 
        {
            CreateMap<Timetable, GetAllTimetablesResponse>();
        }
    }
}
