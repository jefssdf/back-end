using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.CreateServiceStatus
{
    public sealed class CreateServiceStatusMapper : Profile
    {
        public CreateServiceStatusMapper() 
        {
            CreateMap<CreateServiceStatusRequest, ServiceStatus>();
            CreateMap<ServiceStatus, CreateServiceStatusResponse>();
        }
    }
}
