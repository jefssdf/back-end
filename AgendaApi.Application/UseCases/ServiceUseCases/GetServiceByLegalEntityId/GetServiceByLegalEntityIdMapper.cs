using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceUseCases.GetServiceByLegalEntityId
{
    public sealed class GetServiceByLegalEntityIdMapper : Profile
    {
        public GetServiceByLegalEntityIdMapper() 
        {
            CreateMap<Service, GetServiceByLegalEntityIdResponse>();
        }
    }
}
