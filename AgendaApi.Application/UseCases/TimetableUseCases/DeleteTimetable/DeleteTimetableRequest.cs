using MediatR;

namespace AgendaApi.Application.UseCases.TimetableUseCases.DeleteTimetable
{
    public sealed record DeleteTimetableRequest
        : IRequest<List<DeleteTimetableResponse>>;
}
