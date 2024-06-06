using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByNaturalPerson
{
    public sealed class GetAllSchedulingByNaturalPersonHandler
        : IRequestHandler<GetAllSchedulingByNaturalPersonRequest, List<GetAllSchedulingByNaturalPersonResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetAllSchedulingByNaturalPersonHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetAllSchedulingByNaturalPersonResponse>> Handle(GetAllSchedulingByNaturalPersonRequest request,
            CancellationToken cancellationToken)
        {
            var schedulings = await _unitOfWork.SchedulingRepository.GetAllById(s => s.NaturalPersonId == request.id, cancellationToken);
            return _mapper.Map<List<GetAllSchedulingByNaturalPersonResponse>>(schedulings);
        }
    }
}
