using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.AuthenticationUseCases.Login
{
    public sealed class LoginMapper : Profile
    {
        public LoginMapper() 
        {
            CreateMap<LegalEntity, LoginResponse>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.LegalEntityId))
                .ForMember(dest => dest.Email, options => options.MapFrom(src => src.Email))
                .ForMember(dest => dest.Roles, options => options.MapFrom(src => new List<string> { "PJ" }));
            CreateMap<NaturalPerson, LoginResponse>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.NaturalPersonId))
                .ForMember(dest => dest.Email, options => options.MapFrom(src => src.Email))
                .ForMember(dest => dest.Roles, options => options.MapFrom(src => new List<string> { "PF" }));
            CreateMap<SuperAdmin, LoginResponse>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.SuperAdminId))
                .ForMember(dest => dest.Email, options => options.MapFrom(src => src.Email))
                .ForMember(dest => dest.Roles, options => options.MapFrom(src => new List<string> { "Admin" }));
        }
    }
}
