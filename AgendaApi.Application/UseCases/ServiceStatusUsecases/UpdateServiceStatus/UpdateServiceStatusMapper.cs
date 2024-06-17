using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.UpdateServiceStatus
{
    public sealed class UpdateServiceStatusMapper : Profile
    {
        public UpdateServiceStatusMapper() 
        {
            CreateMap<ServiceStatus, UpdateServiceStatusResponse>();
        }
    }
}
