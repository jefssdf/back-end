using AgendaApi.Domain.Interfaces;
using AutoMapper;
using MediatR;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.UpdateNaturalPerson
{
    public sealed class UpdateNaturalPersonHandler
        : IRequestHandler<UpdateNaturalPersonRequest, UpdateNaturalPersonResponse>
    {
        private readonly INaturalPersonRepository _naturalPersonRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateNaturalPersonHandler(INaturalPersonRepository naturalPersonRepository,
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _naturalPersonRepository = naturalPersonRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<UpdateNaturalPersonResponse> Handle(UpdateNaturalPersonRequest request,
            CancellationToken cancellationToken)
        {
            var naturalPerson = await _naturalPersonRepository.GetById(request.id, cancellationToken);

            if (naturalPerson is null) return default;

            naturalPerson.Id = request.id;
            naturalPerson.Name = request.name;
            naturalPerson.Email = request.email;
            naturalPerson.Password = request.password;
            naturalPerson.PhoneNumber = request.phoneNumber;
            naturalPerson.Address = request.address;
            naturalPerson.Cpf = request.cpf;
            naturalPerson.BirthDate = request.birthDate;

            _naturalPersonRepository.Update(naturalPerson);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<UpdateNaturalPersonResponse>(naturalPerson);
        }
    }
}
