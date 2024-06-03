using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.GetAllService
{
    public sealed record GetAllServiceRequest 
        : IRequest<List<GetAllServiceResponse>>;
}
