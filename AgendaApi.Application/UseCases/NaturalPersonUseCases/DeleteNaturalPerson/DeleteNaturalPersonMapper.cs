using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.DeleteNaturalPerson
{
    public sealed class DeleteNaturalPersonMapper : Profile
    {
        public DeleteNaturalPersonMapper() 
        {
            CreateMap<NaturalPerson, DeleteNaturalPersonResponse>();
        }
    }
}
