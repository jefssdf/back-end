using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceUseCases.GetServiceByLegalEntityId
{
    public class GetServiceByLegalEntityIdValidator 
        : AbstractValidator<GetServiceByLegalEntityIdRequest>
    {
        public GetServiceByLegalEntityIdValidator() 
        {
            RuleFor(s => s.id).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}
