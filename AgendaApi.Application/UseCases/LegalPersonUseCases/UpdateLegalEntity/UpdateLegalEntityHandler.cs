using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.UpdateLegalEntity
{
    public class UpdateLegalEntityHandler : 
        IRequestHandler<UpdateLegalEntityRequest, UpdateLegalEntityResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILegalEntityRepository _legalEntityRepository;
        private readonly IMapper _mapper;

        public UpdateLegalEntityHandler(IUnitOfWork unitOfWork, 
            ILegalEntityRepository legalEntityRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _legalEntityRepository = legalEntityRepository;
            _mapper = mapper;
        }

        public async Task<UpdateLegalEntityResponse> Handle(UpdateLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            var entity = await _legalEntityRepository.GetById(request.Id, cancellationToken);

            if (entity is null) return default;

            entity = _mapper.Map<LegalEntity>(request);
            _legalEntityRepository.Update(entity);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateLegalEntityResponse>(entity);
        }
    }
}
