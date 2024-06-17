using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.GetAllServiceStatus
{
    public sealed class GetAllServiceStatusMapper : Profile
    {
        public GetAllServiceStatusMapper() 
        {
            CreateMap<ServiceStatus, GetAllServiceStatusResponse>();
        }
    }
}
