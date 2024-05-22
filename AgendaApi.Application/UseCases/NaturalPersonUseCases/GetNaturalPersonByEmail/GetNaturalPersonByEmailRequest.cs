using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.GetNaturalPersonByEmail
{
    public sealed record GetNaturalPersonByEmailRequest(string email)
        : IRequest<GetNaturalPersonByEmailResponse>;
}
