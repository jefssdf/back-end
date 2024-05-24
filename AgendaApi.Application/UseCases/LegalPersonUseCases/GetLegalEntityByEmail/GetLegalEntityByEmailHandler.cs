using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.LegalPersonUseCases.GetLegalEntityByEmail
{
    public sealed class GetLegalEntityByEmailHandler 
        : IRequestHandler<GetLegalEntityByEmailRequest, GetLegalEntityByEmailResponse>
    {
        private readonly ILegalEntityRepository _legalEntityRepository;
        private readonly IMapper _mapper;

        public GetLegalEntityByEmailHandler(ILegalEntityRepository legalEntityRepository,
            IMapper mapper)
        {
            _legalEntityRepository = legalEntityRepository;
            _mapper = mapper;
        }

        public async Task<GetLegalEntityByEmailResponse> Handle(GetLegalEntityByEmailRequest request,
            CancellationToken cancellationToken)
        {
            var entity = await _legalEntityRepository.GetByEmail(request.email, cancellationToken);
            if (entity is null) return default;

            return _mapper.Map<GetLegalEntityByEmailResponse>(entity);
        }
    }
}
