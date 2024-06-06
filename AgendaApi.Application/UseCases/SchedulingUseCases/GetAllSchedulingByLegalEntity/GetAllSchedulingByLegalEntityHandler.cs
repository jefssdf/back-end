using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByLegalEntity
{
    public sealed class GetAllSchedulingByLegalEntityHandler
        : IRequestHandler<GetAllSchedulingByLegalEntityRequest, List<GetAllSchedulingByLegalEntityResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllSchedulingByLegalEntityHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetAllSchedulingByLegalEntityResponse>> Handle(GetAllSchedulingByLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            var schedulings = await _unitOfWork.SchedulingRepository.GetAllById(s => s.LegalEntityId == request.id, cancellationToken);
            return _mapper.Map<List<GetAllSchedulingByLegalEntityResponse>>(schedulings);
        }
    }
}
