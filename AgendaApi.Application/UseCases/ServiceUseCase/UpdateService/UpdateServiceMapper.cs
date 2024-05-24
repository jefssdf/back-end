using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceUseCase.UpdateService
{
    public sealed class UpdateServiceMapper : Profile
    {
        public UpdateServiceMapper() 
        {
            CreateMap<Service, UpdateServiceResponse>();
        }
    }
}
