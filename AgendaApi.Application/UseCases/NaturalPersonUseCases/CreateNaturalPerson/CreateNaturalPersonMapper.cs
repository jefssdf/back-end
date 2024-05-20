using AgendaApi.Domain.Entities;
using AutoMapper;


namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.CreateNaturalPerson
{
    public sealed class CreateNaturalPersonMapper : Profile
    {
        public CreateNaturalPersonMapper()
        {
            CreateMap<CreateNaturalPersonRequest, NaturalPerson>();
            CreateMap<NaturalPerson, CreateNaturalPersonResponse>();
        }
    }
}
