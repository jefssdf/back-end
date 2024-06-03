using MediatR;

namespace AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables
{
    public sealed record GetAllTimetablesRequest 
        : IRequest<List<GetAllTimetablesResponse>>;
}
