//using AgendaApi.Application.Shared.Extensions;
//using AgendaApi.Domain.Entities;
//using AgendaApi.Domain.Interfaces;
//using AutoMapper;
//using MediatR;

//namespace AgendaApi.Application.UseCases.SchedulingUseCases.CreateScheduling
//{
//    public sealed class CreateSchedulingHandler 
//        : IRequestHandler<CreateSchedulingRequest, CreateSchedulingResponse>
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;
//        public CreateSchedulingHandler(IUnitOfWork unitOfWork, IMapper mapper)
//        {
//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }
//        public async Task<CreateSchedulingResponse> Handle(CreateSchedulingRequest request,
//            CancellationToken cancellationToken)
//        {
//            int weekDayId = (int)request.schedulingDate.DayOfWeek + 1;
//            var weekDay = await _unitOfWork.WeekDayRepository.GetById(wd => wd.WeekDayId == weekDayId, cancellationToken);
//            if (weekDay.Timetables.VerifyAvailability(request.schedulingDate)) ;
//            {
//                Scheduling scheduling = _mapper.Map<Scheduling>(request);
//                _unitOfWork.SchedulingRepository.Create(scheduling);
//                await _unitOfWork.Commit(cancellationToken);
//            }
//        }
//    }
//}
