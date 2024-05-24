using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.UpdateService
{
    public sealed class UpdateServiceHandler
        : IRequestHandler<UpdateServiceRequest, UpdateServiceResponse>
    {
        private readonly IServiceRepository _serviceRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateServiceHandler(IServiceRepository serviceRepository, 
            IMapper mapper, IUnitOfWork unitOfWork)
        {
            _serviceRepository = serviceRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<UpdateServiceResponse> Handle(UpdateServiceRequest request,
            CancellationToken cancellationToken)
        {
            var service = await _serviceRepository.GetById(request.id, cancellationToken);
            
            if (service is null) return default;

            service.Name = request.name;
            service.Description = request.description;
            service.Price = request.price;

            _serviceRepository.Update(service);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateServiceResponse>(service);
        }
    }
}