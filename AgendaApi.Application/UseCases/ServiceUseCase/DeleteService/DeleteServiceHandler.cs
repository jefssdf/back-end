using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.DeleteService
{
    public sealed class DeleteServiceHandler
        : IRequestHandler<DeleteServiceRequest, DeleteServiceResponse>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteServiceHandler(IServiceRepository serviceRepository, 
            IMapper mapper, IUnitOfWork unitOfWork)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteServiceResponse> Handle(DeleteServiceRequest request,
            CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetById(request.id, cancellationToken);
            
            if (service is null) return default;

            _serviceRepository.Delete(service);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteServiceResponse>(service);
        }
    }
}
