using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCases.GetServiceByLegalEntityId
{
    public sealed class GetServiceByLegalEntityIdHandler : 
        IRequestHandler<GetServiceByLegalEntityIdRequest, List<GetServiceByLegalEntityIdResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetServiceByLegalEntityIdHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetServiceByLegalEntityIdResponse>> Handle(GetServiceByLegalEntityIdRequest request,
            CancellationToken cancellationToken)
        {
            var services = await _unitOfWork.ServiceRepository.GetAllServicesByLegalEntityId(request.id, cancellationToken);
            return _mapper.Map<List<GetServiceByLegalEntityIdResponse>>(services);
        }
    }
}
