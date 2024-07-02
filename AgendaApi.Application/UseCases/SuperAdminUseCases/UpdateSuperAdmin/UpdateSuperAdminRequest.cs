using MediatR;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.UpdateSuperAdmin
{
    public sealed record UpdateSuperAdminRequest(Guid superAdminId,
        string email,
        string password)
        : IRequest<UpdateSuperAdminResponse>;
}
