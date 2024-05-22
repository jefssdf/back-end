using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.DeleteLegalEntity
{
    public sealed class DeleteLegalEntityMapper : Profile
    {
        public DeleteLegalEntityMapper() 
        {
            CreateMap<LegalEntity, DeleteLegalEntityResponse>();
        }
    }
}
