using AgendaApi.Application.Shared.Exceptions;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetSchedulingById;
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
            var schedulings = await _unitOfWork.SchedulingRepository.GetAllByIdComplete(s => s.NaturalPersonId == request.naturalPersonId && s.SchedulingStatusId == 1, cancellationToken);
            if (schedulings is null) throw new NotFoundException("Não existem agendamentos para a pessoa selecionada.");
            List<GetAllSchedulingByNaturalPersonResponse> result = new List<GetAllSchedulingByNaturalPersonResponse>();
            foreach (var scheduling in schedulings)
            {
                result.Add(new GetAllSchedulingByNaturalPersonResponse
                {
                    schedulingByIdResponse = _mapper.Map<GetSchedulingByIdResponse>(scheduling),
                    naturalPersonName = scheduling.NaturalPerson.Name,
                    naturalPersonPhone = scheduling.NaturalPerson.PhoneNumber,
                    serviceName = scheduling.Service.Name
                });
            }
            return result;
        }
    }
}
