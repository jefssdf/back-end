using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.ServiceUseCase.DeleteService
{
    public sealed class DeleteServiceHandler
        : IRequestHandler<DeleteServiceRequest, DeleteServiceResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteServiceHandler(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteServiceResponse> Handle(DeleteServiceRequest request,
            CancellationToken cancellationToken)
        {
            var service = await _unitOfWork.ServiceRepository.GetById(s => s.ServiceId == request.id,
                cancellationToken);
            
            if (service is null) return default;

            _unitOfWork.ServiceRepository.Delete(service);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteServiceResponse>(service);
        }
    }
}
