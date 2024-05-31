using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.UpdateNaturalPerson
{
    public sealed class UpdateNaturalPersonHandler
        : IRequestHandler<UpdateNaturalPersonRequest, UpdateNaturalPersonResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateNaturalPersonHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateNaturalPersonResponse> Handle(UpdateNaturalPersonRequest request,
            CancellationToken cancellationToken)
        {
            var naturalPerson = await _unitOfWork.NaturalPersonRepository.GetById(
                np => np.NaturalPersonId == request.id, cancellationToken);

            if (naturalPerson is null) return default;

            naturalPerson.Name = request.name;
            naturalPerson.Email = request.email;
            naturalPerson.Password = request.password;
            naturalPerson.PhoneNumber = request.phoneNumber;
            naturalPerson.Address = request.address;
            naturalPerson.Cpf = request.cpf;
            naturalPerson.BirthDate = request.birthDate;

            _unitOfWork.NaturalPersonRepository.Update(naturalPerson);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateNaturalPersonResponse>(naturalPerson);
        }
    }
}
