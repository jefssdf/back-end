using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.CreateLegalEntity
{
    public sealed record CreateLegalEntityRequest(
        string name,
        string email,
        string password,
        string phoneNumber)
        : IRequest<CreateLegalEntityResponse>;
}
