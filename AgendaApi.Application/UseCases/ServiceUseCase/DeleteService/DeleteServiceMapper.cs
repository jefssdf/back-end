using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceUseCase.DeleteService
{
    public sealed class DeleteServiceMapper : Profile
    {
        public DeleteServiceMapper() 
        {
            CreateMap<Service, DeleteServiceResponse>();
        }
    }
}
