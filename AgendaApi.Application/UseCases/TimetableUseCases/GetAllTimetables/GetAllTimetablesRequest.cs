using MediatR;

namespace AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables
{
    public sealed record GetAllTimetablesRequest(Guid legalEntityId) 
        : IRequest<List<GetAllTimetablesResponse>>;
}
