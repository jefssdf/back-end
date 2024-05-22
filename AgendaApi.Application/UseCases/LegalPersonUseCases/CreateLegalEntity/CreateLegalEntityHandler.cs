using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.CreateLegalEntity
{
    public sealed class CreateLegalEntityHandler :
        IRequestHandler<CreateLegalEntityRequest, CreateLegalEntityResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILegalEntityRepository _legalEntityRepository;
        private readonly IMapper _mapper;

        public CreateLegalEntityHandler(IUnitOfWork unitOfWork,
            ILegalEntityRepository legalEntityRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _legalEntityRepository = legalEntityRepository;
            _mapper = mapper;
        }
        public async Task<CreateLegalEntityResponse> Handle(CreateLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            var legalEntity = _mapper.Map<LegalEntity>(request);
            _legalEntityRepository.Create(legalEntity);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateLegalEntityResponse>(legalEntity);
        }
    }
}
