using MediatR;

namespace AgendaApi.Application.UseCases.AuthenticationUseCases.Login
{
    public sealed record LoginRequest(string email,
        string password) 
        : IRequest<LoginResponse>;
}
