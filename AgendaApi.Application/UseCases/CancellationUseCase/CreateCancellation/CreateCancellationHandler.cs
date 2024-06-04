using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.CancellationUseCase.CreateCancellation
{
    public sealed class CreateCancellationHandler
        : IRequestHandler<CreateCancellationRequest, CreateCancellationResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreateCancellationHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CreateCancellationResponse> Handle(CreateCancellationRequest request,
            CancellationToken cancellationToken)
        {
            var cancellation = _mapper.Map<Cancellation>(request);
            if (cancellation is null) return default;

            _unitOfWork.CancellationRepository.Create(cancellation);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateCancellationResponse>(cancellation);
        }
    }
}
