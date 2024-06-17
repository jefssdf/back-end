using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceUseCases.UpdateServiceAvailability
{
    public sealed class UpdateServiceAvailabilityMapper : Profile
    {
        public UpdateServiceAvailabilityMapper() 
        {
            CreateMap<Service, UpdateServiceAvailabilityResponse>();
        }
    }
}
