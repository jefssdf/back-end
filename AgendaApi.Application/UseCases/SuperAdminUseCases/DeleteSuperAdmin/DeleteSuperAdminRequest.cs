using MediatR;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.DeleteSuperAdmin
{
    public sealed record DeleteSuperAdminRequest(Guid superAdminId)
        : IRequest<DeleteSuperAdminResponse>;
}
