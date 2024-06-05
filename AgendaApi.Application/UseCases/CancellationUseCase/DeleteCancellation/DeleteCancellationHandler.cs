using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.CancellationUseCase.DeleteCancellation
{
    public sealed class DeleteCancellationHandler
        : IRequestHandler<DeleteCancellationRequest, DeleteCancellationResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public DeleteCancellationHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DeleteCancellationResponse> Handle(DeleteCancellationRequest request,
            CancellationToken cancellationToken)
        {
            var cancellation = await _unitOfWork.CancellationRepository.GetById(
                c => c.CancellationId == request.id, cancellationToken);
            if (cancellation is null) return default;

            _unitOfWork.CancellationRepository.Delete(cancellation);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteCancellationResponse>(cancellation);
        }
    }
}
