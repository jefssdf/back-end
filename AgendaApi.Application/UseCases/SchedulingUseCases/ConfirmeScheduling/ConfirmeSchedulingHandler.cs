using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.ConfirmeScheduling
{
    public sealed class ConfirmeSchedulingHandler
        : IRequestHandler<ConfirmeSchedulingRequest, ConfirmeSchedulingResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ConfirmeSchedulingHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<ConfirmeSchedulingResponse> Handle(ConfirmeSchedulingRequest request,
            CancellationToken cancellationToken)
        {
            var scheduling = await _unitOfWork.SchedulingRepository.GetById(s => s.SchedulingId == request.id, cancellationToken);
            if (scheduling is null) return default;

            scheduling.ConfirmationDate = DateTime.Now;
            scheduling.SchedulingStatusId = 2;
            _unitOfWork.SchedulingRepository.Update(scheduling);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<ConfirmeSchedulingResponse>(scheduling);
        }
    }
}
