using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.GetAllService
{
    public sealed class GetAllServiceHandler
        : IRequestHandler<GetAllServiceRequest, List<GetAllServiceResponse>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllServiceHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<GetAllServiceResponse>> Handle(GetAllServiceRequest request,
            CancellationToken cancellationToken)
        {
            var services = await _unitOfWork.ServiceRepository.GetAll(cancellationToken);
            return _mapper.Map<List<GetAllServiceResponse>>(services);
        }
    }
}
