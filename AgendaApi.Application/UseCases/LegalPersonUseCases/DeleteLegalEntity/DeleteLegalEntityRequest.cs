using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.DeleteLegalEntity
{
    public sealed record DeleteLegalEntityRequest(Guid Id)
        : IRequest<DeleteLegalEntityResponse>;
}
