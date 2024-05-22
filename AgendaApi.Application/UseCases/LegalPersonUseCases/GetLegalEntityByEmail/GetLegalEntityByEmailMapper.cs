using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.GetLegalEntityByEmail
{
    public sealed class GetLegalEntityByEmailMapper : Profile
    {
        public GetLegalEntityByEmailMapper()
        {
            CreateMap<LegalEntity, GetLegalEntityByEmailResponse>();
        }
    }
}
