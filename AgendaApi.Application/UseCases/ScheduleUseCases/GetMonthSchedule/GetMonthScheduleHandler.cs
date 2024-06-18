using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ScheduleUseCases.GetMonthSchedule
{
    public sealed class GetMonthScheduleHandler
        : IRequestHandler<GetMonthScheduleRequest, GetMonthScheduleResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetMonthScheduleHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetMonthScheduleResponse> Handle(GetMonthScheduleRequest request,
            CancellationToken cancellationToken)
        {
            var schedulings = await _unitOfWork.SchedulingRepository.GetAllByDate(s => s.SchedulingDate.Month == request.date.Month && s.LegalEntityId == request.id && s.SchedulingStatusId == 1, cancellationToken);
            var timetables = await _unitOfWork.TimetableRepository.GetAllById(tt => tt.LegalEntityId == request.id, cancellationToken);
            List<FreeMonthScheduleResponse> freeMonthSchedule = new List<FreeMonthScheduleResponse>();

            foreach ( var timetable in timetables )
            {
                TimeOnly currentTime = timetable.StartTime;
                while (currentTime < timetable.EndTime )
                {
                    freeMonthSchedule.Add(new FreeMonthScheduleResponse
                    {
                        AvailableTime = currentTime.ToString("HH:mm"),
                        WeekDayId = timetable.WeekDayId,
                    });

                    currentTime = currentTime.AddMinutes(30);
                }
            }
            return new GetMonthScheduleResponse
            {
                Schedulings = _mapper.Map<List<GetAllSchedulingResponse>>(schedulings),
                AvailableTimes = freeMonthSchedule
            };
        }
    }
}
