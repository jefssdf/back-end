using MediatR;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.GetSuperAdminByEmail
{
    public sealed record GetSuperAdminByEmailRequest(string email)
        : IRequest<GetSuperAdminByEmailResponse>;
}
