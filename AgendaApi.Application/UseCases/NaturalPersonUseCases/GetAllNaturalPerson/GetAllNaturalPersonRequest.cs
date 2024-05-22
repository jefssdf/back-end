using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.GetAllNaturalPerson
{
    public sealed record GetAllNaturalPersonRequest 
        : IRequest<List<GetAllNaturalPersonResponse>>;
}
