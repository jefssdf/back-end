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
                .ForMember(dest => dest.UserName, options => options.MapFrom(src => src.Name))
                .ForMember(dest => dest.Roles, options => options.MapFrom(src => new List<string> { "Client" }));
            CreateMap<NaturalPerson, LoginResponse>()
                .ForMember(dest => dest.Id, options => options.MapFrom(src => src.NaturalPersonId))
                .ForMember(dest => dest.Email, options => options.MapFrom(src => src.Email))
                .ForMember(dest => dest.UserName, options => options.MapFrom(src => src.Name))
                .ForMember(dest => dest.Roles, options => options.MapFrom(src => new List<string> { "Client" }));
        }
    }
}
