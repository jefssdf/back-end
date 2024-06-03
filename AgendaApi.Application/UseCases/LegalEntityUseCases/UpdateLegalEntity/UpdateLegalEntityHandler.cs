using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.UpdateLegalEntity
{
    public sealed class UpdateLegalEntityHandler : 
        IRequestHandler<UpdateLegalEntityRequest, UpdateLegalEntityResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateLegalEntityHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateLegalEntityResponse> Handle(UpdateLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.LegalEntityRepository.GetById(le => le.LegalEntityId == request.id,
                cancellationToken);

            if (entity is null) return default;

            _mapper.Map(request, entity);
            _unitOfWork.LegalEntityRepository.Update(entity);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateLegalEntityResponse>(entity);
        }
    }
}
