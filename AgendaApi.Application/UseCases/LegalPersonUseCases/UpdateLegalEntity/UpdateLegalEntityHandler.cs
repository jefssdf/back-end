using AgendaApi.Domain.Entities;
using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;
using System.Diagnostics.CodeAnalysis;

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

            entity.Name = request.name;
            entity.Email = request.email;
            entity.Password = request.password;
            entity.PhoneNumber = request.phoneNumber;
            entity.Address = request.address;
            entity.Cnpj = request.cnpj;
            entity.SocialName = request.socialName;

            _legalEntityRepository.Update(entity);

            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateLegalEntityResponse>(entity);
        }
    }
}
