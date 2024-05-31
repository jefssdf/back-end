using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.GetLegalEntityByEmail
{
    public sealed class GetLegalEntityByEmailHandler 
        : IRequestHandler<GetLegalEntityByEmailRequest, GetLegalEntityByEmailResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetLegalEntityByEmailHandler(IUnitOfWork unitOfWork,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GetLegalEntityByEmailResponse> Handle(GetLegalEntityByEmailRequest request,
            CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.LegalEntityRepository.GetByEmail(request.email, cancellationToken);
            if (entity is null) return default;

            return _mapper.Map<GetLegalEntityByEmailResponse>(entity);
        }
    }
}
