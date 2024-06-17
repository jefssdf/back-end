using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.DeleteServiceStatus
{
    public sealed class DeleteServiceStatusMapper : Profile
    {
        public DeleteServiceStatusMapper() 
        {
            CreateMap<ServiceStatus, DeleteServiceStatusResponse>();
        }
    }
}
