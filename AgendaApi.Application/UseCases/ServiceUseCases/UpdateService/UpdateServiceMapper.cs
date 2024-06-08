using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.ServiceUseCase.UpdateService
{
    public sealed class UpdateServiceMapper : Profile
    {
        public UpdateServiceMapper() 
        {
            CreateMap<Service, UpdateServiceResponse>()
                .ForMember(dest => dest.Duration, opt => opt.MapFrom(src => TimeSpan.Parse(src.Duration.ToString("00:00"))));
        }
    }
}
