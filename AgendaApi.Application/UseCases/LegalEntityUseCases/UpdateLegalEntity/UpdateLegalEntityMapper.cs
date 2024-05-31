using AgendaApi.Domain.Entities;
using AutoMapper;    

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.UpdateLegalEntity
{
    public sealed class UpdateLegalEntityMapper : Profile
    {
        public UpdateLegalEntityMapper() 
        {
            CreateMap<UpdateLegalEntityRequest, LegalEntity>();
            CreateMap<LegalEntity, UpdateLegalEntityResponse>();
        }
    }
}
