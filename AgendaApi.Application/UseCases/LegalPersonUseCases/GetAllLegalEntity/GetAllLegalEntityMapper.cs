using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.GetAllLegalEntity
{
    public sealed class GetAllLegalEntityMapper : Profile
    {
        public GetAllLegalEntityMapper() 
        {
            CreateMap<LegalEntity, GetAllLegalEntityResponse>();
        }
    }
    
}
