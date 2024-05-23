using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.CreateLegalEntity
{
    public sealed class CreateLegalEntityMapper : Profile
    {
        public CreateLegalEntityMapper() 
        {
            CreateMap<CreateLegalEntityRequest, LegalEntity>();
            CreateMap<LegalEntity, CreateLegalEntityResponse>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.LegalEntityId));
        }
    }
}
