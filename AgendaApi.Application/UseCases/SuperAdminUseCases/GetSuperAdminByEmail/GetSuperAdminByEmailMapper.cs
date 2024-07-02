using AgendaApi.Domain.Entities;
using AutoMapper;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.GetSuperAdminByEmail
{
    public sealed class GetSuperAdminByEmailMapper : Profile
    {
        public GetSuperAdminByEmailMapper() 
        {
            CreateMap<SuperAdmin, GetSuperAdminByEmailResponse>();
        }
    }
}
