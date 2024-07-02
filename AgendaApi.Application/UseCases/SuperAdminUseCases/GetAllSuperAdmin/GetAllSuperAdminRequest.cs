using MediatR;

namespace AgendaApi.Application.UseCases.SuperAdminUseCases.GetAllSuperAdmin
{
    public sealed record GetAllSuperAdminRequest
        : IRequest<List<GetAllSuperAdminResponse>>;
}
