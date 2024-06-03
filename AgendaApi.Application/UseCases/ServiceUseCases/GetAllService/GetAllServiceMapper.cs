using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceUseCase.GetAllService
{
    public sealed class GetAllServiceMapper : Profile
    {
        public GetAllServiceMapper() 
        {
            CreateMap<Service, GetAllServiceResponse>();
        }
    }
}
