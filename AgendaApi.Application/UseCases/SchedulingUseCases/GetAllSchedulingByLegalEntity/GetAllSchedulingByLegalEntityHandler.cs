using AgendaApi.Application.Shared.Exceptions;
using AgendaApi.Application.UseCases.SchedulingUseCases.GetSchedulingById;
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
            var schedulings = await _unitOfWork.SchedulingRepository.GetAllByIdComplete(s => s.LegalEntityId == request.legalEntityId && s.SchedulingStatusId == 1, cancellationToken);
            if (schedulings is null) throw new NotFoundException("Não existem agendamentos para a pessoa selecionada.");
            List<GetAllSchedulingByLegalEntityResponse> result = new List<GetAllSchedulingByLegalEntityResponse>();
            foreach (var scheduling in schedulings)
            {
                result.Add(new GetAllSchedulingByLegalEntityResponse
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