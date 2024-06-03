using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.CreateNaturalPerson
{
    public sealed record CreateNaturalPersonRequest(
        string name, 
        string email, 
        string password, 
        string phoneNumber)
        : IRequest<CreateNaturalPersonResponse>;
}
