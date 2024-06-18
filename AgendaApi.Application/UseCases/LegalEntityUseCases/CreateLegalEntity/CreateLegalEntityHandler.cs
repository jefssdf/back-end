using AgendaApi.Application.Shared.Exceptions;
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
        private readonly IMapper _mapper;

        public CreateLegalEntityHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<CreateLegalEntityResponse> Handle(CreateLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            var legalEntityRegistered = await _unitOfWork.LegalEntityRepository.GetByEmail(le => le.Email == request.email, cancellationToken);
            var naturalPersonRegistered = await _unitOfWork.NaturalPersonRepository.GetByEmail(np => np.Email == request.email, cancellationToken);
            if (legalEntityRegistered != null || naturalPersonRegistered != null) throw new BadRequestException("Email já cadastrado.");

            var legalEntity = _mapper.Map<LegalEntity>(request);
            _unitOfWork.LegalEntityRepository.Create(legalEntity);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateLegalEntityResponse>(legalEntity);
        }
    }
}
