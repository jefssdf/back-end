using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceUseCase.GetServiceById
{
    public class GetServiceByIdValidator : AbstractValidator<GetServiceByIdRequest>
    {
        public GetServiceByIdValidator() 
        {
            RuleFor(s => s.id).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}
