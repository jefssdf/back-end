using AgendaApi.Domain.Entities;
using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.CreateServiceStatus
{
    public class CreateServiceStatusValidator : AbstractValidator<CreateServiceStatusRequest>
    {
        public CreateServiceStatusValidator() 
        {
            RuleFor(ss => ss.serviceStatusId).NotEmpty().NotNull()
                .InclusiveBetween(1, 2);
            RuleFor(ss => ss.statusName).NotEmpty().NotNull();
        }
    }
}
