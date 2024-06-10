using AgendaApi.Application.Shared.Exceptions.SchedulingExceptions;
using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.CreateScheduling
{
    public sealed class CreateSchedulingHandler
        : IRequestHandler<CreateSchedulingRequest, CreateSchedulingResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreateSchedulingHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CreateSchedulingResponse> Handle(CreateSchedulingRequest request,
            CancellationToken cancellationToken)
        {
            int weekDayId = (int)request.schedulingDate.DayOfWeek + 1;
            WeekDay weekDay = await _unitOfWork.WeekDayRepository.GetById(wd => wd.WeekDayId == weekDayId, cancellationToken);
            Service service = await _unitOfWork.ServiceRepository.GetById(s => s.ServiceId == request.serviceId, cancellationToken);
            IEnumerable<Scheduling> schedulings= await _unitOfWork.SchedulingRepository.GetAllByDate(s => s.SchedulingDate.Date == request.schedulingDate.Date, cancellationToken);
            TimeOnly schedulingStartTime = TimeOnly.FromDateTime(request.schedulingDate);
            TimeOnly schedulingEndTime = schedulingStartTime.Add(service.Duration);
            bool verificator = false;

            foreach (var timetable in weekDay.Timetables)
            {
                if (timetable.StartTime < schedulingStartTime && timetable.EndTime > schedulingEndTime) verificator = true; 
            }

            if (verificator) throw new UnavailableScheduling("Horário indisponível.");

            foreach (var scheduling in schedulings)
            {
                if ((request.schedulingDate >= scheduling.SchedulingDate && request.schedulingDate < scheduling.SchedulingDate.Add(scheduling.Service.Duration)) ||
                    (request.schedulingDate.Add(service.Duration) > scheduling.SchedulingDate && request.schedulingDate.Add(service.Duration) <= scheduling.SchedulingDate.Add(scheduling.Service.Duration)) ||
                    request.schedulingDate <= scheduling.SchedulingDate && request.schedulingDate.Add(service.Duration) >= scheduling.SchedulingDate.Add(scheduling.Service.Duration))
                {
                        throw new UnavailableScheduling("Horário solicitado conflita com outros agendamentos.");
                }
            }

            Scheduling newScheduling = _mapper.Map<Scheduling>(request);
            _unitOfWork.SchedulingRepository.Create(newScheduling);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateSchedulingResponse>(newScheduling);
        }
    }
}
