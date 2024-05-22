using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.GetLegalEntityByEmail
{
    public sealed record GetLegalEntityByEmailRequest(string email) 
        : IRequest<GetLegalEntityByEmailResponse>;
    
}
