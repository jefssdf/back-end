using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.UpdateNaturalPerson
{
    public sealed record UpdateNaturalPersonRequest(
        Guid id,
        string name,
        string email,
        string password,
        string phoneNumber) 
        : IRequest<UpdateNaturalPersonResponse>
    {
    }
}
