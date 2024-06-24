using AgendaApi.Application.UseCases.SchedulingUseCases.GetAllScheduling;
using AgendaApi.Application.UseCases.ServiceUseCases.GetServiceByLegalEntityId;
using AgendaApi.Application.UseCases.TimetableUseCases.GetAllTimetables;
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
            var schedulings = await _unitOfWork.SchedulingRepository.GetAllByDate(s => s.SchedulingDate.Month == request.date.Month && s.LegalEntityId == request.legalEntityId && s.SchedulingStatusId == 1, cancellationToken);
            var timetables = await _unitOfWork.TimetableRepository.GetAllById(tt => tt.LegalEntityId == request.legalEntityId, cancellationToken);
            List<RequestedInfo> requestedInfos = new List<RequestedInfo>();

            foreach (var scheduling in schedulings)
            {
                requestedInfos.Add(new RequestedInfo
                {
                    ServiceName = scheduling.Service.Name,
                    ServiceDuration = scheduling.Service.Duration.ToString(),
                    NaturalPersonName = scheduling.NaturalPerson.Name
                });
            }


            return new GetMonthScheduleResponse
            {
                Schedulings = _mapper.Map<List<GetAllSchedulingResponse>>(schedulings),
                AvailableTimes = _mapper.Map<List<GetAllTimetablesResponse>>(timetables),
                Info = requestedInfos
            };
        }
    }
}
