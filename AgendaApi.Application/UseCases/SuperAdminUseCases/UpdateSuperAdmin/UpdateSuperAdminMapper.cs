using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.UpdateSuperAdmin
{
    public sealed class UpdateSuperAdminMapper : Profile
    {
        public UpdateSuperAdminMapper() 
        {
            CreateMap<UpdateSuperAdminRequest, SuperAdmin>();
            CreateMap<SuperAdmin, UpdateSuperAdminResponse>();
        }
    }
}
