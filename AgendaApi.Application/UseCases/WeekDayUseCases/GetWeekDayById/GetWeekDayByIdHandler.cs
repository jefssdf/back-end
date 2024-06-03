using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById
{
    public sealed class GetWeekDayByIdHandler
        : IRequestHandler<GetWeekDayByIdRequest, List<FreeSchedulingResponseById>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetWeekDayByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<FreeSchedulingResponseById>> Handle(GetWeekDayByIdRequest request,
            CancellationToken cancellationToken)
        {
            var weekDay = await _unitOfWork.WeekDayRepository.GetById(
                wd => wd.WeekDayId == request.id, cancellationToken);

            if (weekDay is null) return default;

            List<AvailableTimeDTOById> availableTimeList = new List<AvailableTimeDTOById>();
            foreach (var timetable in weekDay.Timetables)
            {
                while (timetable.StartTime < timetable.EndTime)
                {
                    availableTimeList.Add(new AvailableTimeDTOById
                    {
                        StartTime = timetable.StartTime,
                        WeekDayId = timetable.WeekDayId
                    });
                    timetable.StartTime = timetable.StartTime.AddMinutes(30);
                }
            };
            return _mapper.Map<List<FreeSchedulingResponseById>>(availableTimeList);
        }
    }
}
