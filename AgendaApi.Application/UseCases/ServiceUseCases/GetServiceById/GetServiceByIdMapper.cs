using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceUseCase.GetServiceById
{
    public sealed class GetServiceByIdMapper : Profile
    {
        public GetServiceByIdMapper() 
        {
            CreateMap<Service, GetServiceByIdResponse>();
        }
    }
}
