using AgendaApi.Application.Shared.Extensions;
using AgendaApi.Application.UseCases.SchedulingUseCases.DTOs;
using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById
{
    public sealed class GetWeekDayByIdHandler
        : IRequestHandler<GetWeekDayByIdRequest, GetWeekDayByIdResponseComplete>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetWeekDayByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<GetWeekDayByIdResponseComplete> Handle(GetWeekDayByIdRequest request,
            CancellationToken cancellationToken)
        {
            var weekDay = await _unitOfWork.WeekDayRepository.GetById(
                wd => wd.WeekDayId == request.id, cancellationToken);

            List<AvailableTimeDTOById> availableTimeList = new List<AvailableTimeDTOById>();
            List<SchedulingBaseResponse> timetableSchedulings = new List<SchedulingBaseResponse>();

            foreach (var timetable in weekDay.Timetables)
            {
                var schedulings = await _unitOfWork.SchedulingRepository.GetAllById(s => s.TimetableId == timetable.TimetableId, cancellationToken);
                timetableSchedulings.AddRange(_mapper.Map<List<SchedulingBaseResponse>>(schedulings)) ;
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


            return new GetWeekDayByIdResponseComplete
            {
                availableTimes = availableTimeList,
                schedulings = _mapper.Map<List<SchedulingBaseResponse>>(timetableSchedulings),
                totalSchedulings = timetableSchedulings.Count()
            };
        }
    }
}

//----------------------------------------------------------
//namespace AgendaApi.Application.UseCases.WeekDayUseCases.GetWeekDayById
//{
//    public sealed class GetWeekDayByIdHandler
//        : IRequestHandler<GetWeekDayByIdRequest, GetWeekDayByIdResponse>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;

//        public GetWeekDayByIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public async Task<GetWeekDayByIdResponse> Handle(GetWeekDayByIdRequest request,
//            CancellationToken cancellationToken)
//        {
//            var weekDay = await _unitOfWork.WeekDayRepository.GetById(
//                wd => wd.WeekDayId == request.Id,
//                cancellationToken);

//            if (weekDay == null)
//            {
//                return new GetWeekDayByIdResponse
//                {
//                    AvailableTimes = new List<FreeSchedulingResponseById>(),
//                    Schedulings = new List<SchedulingBaseResponse>(),
//                    TotalSchedulings = 0
//                };
//            }

//            List<AvailableTimeDTOById> availableTimeList = new List<AvailableTimeDTOById>();
//            foreach (var timetable in weekDay.Timetables)
//            {
//                var schedulings = await _unitOfWork.SchedulingRepository.GetAllById(s => s.TimetableId == timetable.TimetableId)
//                    .ToListAsync(cancellationToken);
//                var service = await _unitOfWork.ServiceRepository.GetById(s => s.ServiceId == )
//                TimeOnly currentTime = timetable.StartTime;

//                while (currentTime.Add(serviceDuration) <= timetable.EndTime)
//                {
//                    bool isSlotAvailable = true;

//                    foreach (var scheduling in schedulings)
//                    {
//                        var scheduledStartTime = TimeOnly.FromDateTime(scheduling.SchedulingDate);
//                        var scheduledEndTime = scheduledStartTime.Add(scheduling.Service.Duration);

//                        if (currentTime < scheduledEndTime && currentTime.Add(serviceDuration) > scheduledStartTime)
//                        {
//                            isSlotAvailable = false;
//                            break;
//                        }
//                    }

//                    if (isSlotAvailable)
//                    {
//                        availableTimeList.Add(new AvailableTimeDTOById
//                        {
//                            StartTime = currentTime,
//                            WeekDayId = timetable.WeekDayId
//                        });
//                    }

//                    currentTime = currentTime.Add(serviceDuration);
//                }
//            }

//            var allSchedulings = await _unitOfWork.SchedulingRepository
//                .GetAll()
//                .Where(s => s.Timetable.WeekDayId == request.Id && s.SchedulingDate.Date == DateTime.Today)
//                .ToListAsync(cancellationToken);

//            var totalSchedulings = allSchedulings.Count;
//            var pagedSchedulings = allSchedulings
//                .Skip((request.PageNumber - 1) * request.PageSize)
//                .Take(request.PageSize)
//                .ToList();

//            var schedulingDtos = _mapper.Map<List<SchedulingDto>>(pagedSchedulings);

//            return new GetWeekDayByIdResponse
//            {
//                AvailableTimes = _mapper.Map<List<FreeSchedulingResponseById>>(availableTimeList),
//                Schedulings = schedulingDtos,
//                TotalSchedulings = totalSchedulings
//            };
//        }
//    }
//}
