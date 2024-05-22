using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.UpdateNaturalPerson
{
    public sealed class UpdateNaturalPersonMapper : Profile
    {
        public UpdateNaturalPersonMapper() 
        {
            CreateMap<UpdateNaturalPersonRequest, NaturalPerson>();
            CreateMap<NaturalPerson, UpdateNaturalPersonResponse>();
        }
    }
}
