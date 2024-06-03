using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById
{
    public sealed record GetWeekDayByIdRequest(int id) 
        : IRequest<List<FreeSchedulingResponseById>>;
}
