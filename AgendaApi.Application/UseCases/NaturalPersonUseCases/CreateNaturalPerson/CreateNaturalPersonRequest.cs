using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.CreateNaturalPerson
{
    public sealed record CreateNaturalPersonRequest(
        string name, 
        string email, 
        string password, 
        string phoneNumber, 
        string address, 
        string cpf, 
        DateTimeOffset birthDate)
        : IRequest<CreateNaturalPersonResponse>;
}
