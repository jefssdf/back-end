using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.GetAllLegalEntity
{
    public sealed class GetAllLegalEntityMapper : Profile
    {
        public GetAllLegalEntityMapper() 
        {
            CreateMap<LegalEntity, GetAllLegalEntityResponse>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.LegalEntityId));
        }
    }
    
}
