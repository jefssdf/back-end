using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.UpdateLegalEntity
{
    public sealed record UpdateLegalEntityRequest(
        Guid id, 
        string name,
        string email, 
        string password, 
        string phoneNumber) 
        : IRequest<UpdateLegalEntityResponse>;
}
