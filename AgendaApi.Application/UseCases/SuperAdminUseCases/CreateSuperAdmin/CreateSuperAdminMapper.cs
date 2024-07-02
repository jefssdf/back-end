using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.CreateSuperAdmin
{
    public sealed class CreateSuperAdminMapper : Profile
    {
        public CreateSuperAdminMapper() 
        {
            CreateMap<CreateSuperAdminRequest, SuperAdmin>();
            CreateMap<SuperAdmin, CreateSuperAdminResponse>();
        }
    }
}
