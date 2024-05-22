using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.GetNaturalPersonByEmail
{
    public sealed class GetNaturalPersonByEmailMapper : Profile
    {
        public GetNaturalPersonByEmailMapper() 
        {
            CreateMap<NaturalPerson, GetNaturalPersonByEmailResponse>();
        }
    }
}
