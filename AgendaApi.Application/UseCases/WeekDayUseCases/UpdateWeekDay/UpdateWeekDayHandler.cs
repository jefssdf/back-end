using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.WeekDayUseCases.UpdateWeekDay
{
    public sealed class UpdateWeekDayHandler
        : IRequestHandler<UpdateWeekDayRequest, UpdateWeekDayResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public UpdateWeekDayHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<UpdateWeekDayResponse> Handle(UpdateWeekDayRequest request,
            CancellationToken cancellationToken)
        {
            var weekDay = await _unitOfWork.WeekDayRepository.GetById(
                wd => wd.WeekDayId == request.id, cancellationToken);

            if (weekDay is null) return default;

            _mapper.Map(request, weekDay);
            _unitOfWork.WeekDayRepository.Update(weekDay);
            _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateWeekDayResponse>(weekDay);
        }
    }
}
