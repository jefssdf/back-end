using AgendaApi.Application.Shared.Exceptions;
using AgendaApi.Application.Shared.PasswordHashing;
using AgendaApi.Application.Shared.TokenServices;
using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.AuthenticationUseCases.Login
{
    public sealed class LoginHandler
        : IRequestHandler<LoginRequest, LoginResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public LoginHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, 
            CancellationToken cancellationToken)
        {
            var legalEntity = await _unitOfWork.LegalEntityRepository.GetByEmail(
                le => le.Email == request.email, cancellationToken);
            if (legalEntity is null) 
            {
                var naturalPerson = await _unitOfWork.NaturalPersonRepository.GetByEmail(
                    np => np.Email == request.email, cancellationToken);
                if (naturalPerson is null) throw new NotFoundException("Usuário não encontrado.");
                
                var npIsVerified = PasswordHashingService.Verify(request.password, naturalPerson.Password!);
                if (!npIsVerified) throw new BadRequestException("Seha inncorreta.");

                var naturalPersoResponse = _mapper.Map<LoginResponse>(naturalPerson);
                naturalPersoResponse.Token = TokenService.GenerateAccessToken(naturalPersoResponse);
                return naturalPersoResponse;
            }
            var legalEntityResponse = _mapper.Map<LoginResponse>(legalEntity);
            var lpIsVerified = PasswordHashingService.Verify(request.password, legalEntity.Password!);
            if (!lpIsVerified) throw new BadRequestException("Seha incorreta.");
            legalEntityResponse.Token = TokenService.GenerateAccessToken(legalEntityResponse);
            return legalEntityResponse;
        }
    }
}
