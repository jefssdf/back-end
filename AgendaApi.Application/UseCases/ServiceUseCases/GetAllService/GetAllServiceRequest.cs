using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.GetAllService
{
    public sealed record GetAllServiceRequest(Guid legalEntityId) 
        : IRequest<List<GetAllServiceResponse>>;
}
