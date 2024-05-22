using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.DeleteNaturalPerson
{
    public sealed record DeleteNaturalPersonRequest(Guid id)
        : IRequest<DeleteNaturalPersonResponse>;
}
