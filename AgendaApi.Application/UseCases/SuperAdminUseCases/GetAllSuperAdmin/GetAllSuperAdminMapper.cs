using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.GetAllSuperAdmin
{
    public sealed class GetAllSuperAdminMapper : Profile
    {
        public GetAllSuperAdminMapper() 
        {
            CreateMap<SuperAdmin, GetAllSuperAdminResponse>();
        }
    }
}
