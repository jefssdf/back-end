using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.DeleteSuperAdmin
{
    public sealed class DeleteSuperAdminMapper : Profile
    {
        public DeleteSuperAdminMapper() 
        {
            CreateMap<SuperAdmin, DeleteSuperAdminResponse>();
        }
    }
}
