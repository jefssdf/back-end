using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceUseCase.GetAllService
{
    public class GetAllServiceValidator 
        : AbstractValidator<GetAllServiceRequest>
    {
        public GetAllServiceValidator() 
        {
            RuleFor(s => s.legalEntityId).NotEmpty()
                .Must(GuidValidator.BeValid);
        }
    }
}
