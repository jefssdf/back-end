using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.GetAllLegalEntity
{
    public sealed record GetAllLegalEntityRequest 
        : IRequest<List<GetAllLegalEntityResponse>>;
}
