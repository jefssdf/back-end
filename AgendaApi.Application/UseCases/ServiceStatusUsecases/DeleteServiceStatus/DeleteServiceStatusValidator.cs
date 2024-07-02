using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.DeleteServiceStatus
{
    public class DeleteServiceStatusValidator : AbstractValidator<DeleteServiceStatusRequest>
    {
        public DeleteServiceStatusValidator() 
        {
            RuleFor(ss => ss.serviceStatusId).NotEmpty().NotNull();
        }
    }
}
