using MediatR;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.CreateSuperAdmin
{
    public sealed record CreateSuperAdminRequest(string email,
        string password)
        : IRequest<CreateSuperAdminResponse>;
}
