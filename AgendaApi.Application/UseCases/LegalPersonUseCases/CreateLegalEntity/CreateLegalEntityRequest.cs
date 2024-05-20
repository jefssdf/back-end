using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.CreateLegalEntity
{
    public sealed record CreateLegalEntityRequest(
        string name,
        string email,
        string password,
        string phoneNumber,
        string address,
        string cnpj,
        string socialName)
        : IRequest<CreateLegalEntityResponse>;
}
