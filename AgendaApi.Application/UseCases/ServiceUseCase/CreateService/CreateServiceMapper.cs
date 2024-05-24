using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceUseCase.CreateService
{
    public sealed class CreateServiceMapper : Profile
    {
        public CreateServiceMapper() 
        {
            CreateMap<CreateServiceRequest, Service>();
            CreateMap<Service, CreateServiceResponse>();
        }
    }
}
