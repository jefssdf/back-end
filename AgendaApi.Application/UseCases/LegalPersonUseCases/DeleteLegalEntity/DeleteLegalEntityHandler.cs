using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.DeleteLegalEntity
{
    public sealed class DeleteLegalEntityHandler : IRequestHandler<DeleteLegalEntityRequest, DeleteLegalEntityResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILegalEntityRepository _legalEntityRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DeleteLegalEntityHandler(IMapper mapper, 
            ILegalEntityRepository legalEntityRepository, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _legalEntityRepository = legalEntityRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<DeleteLegalEntityResponse> Handle(DeleteLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            var entity = await _legalEntityRepository.GetById(request.Id, cancellationToken);
            if (entity == null) return default;

            _legalEntityRepository.Delete(entity);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<DeleteLegalEntityResponse>(entity);
        }
    }
}
