using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.GetAllNaturalPerson
{
    public sealed class GetAllNaturalPersonMapper : Profile
    {
        public GetAllNaturalPersonMapper() 
        {
            CreateMap<NaturalPerson, GetAllNaturalPersonResponse>();
        }
    }
}
