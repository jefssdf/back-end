using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceStatusUsecases.UpdateServiceStatus
{
    public class UpdateServiceStatusValidator : AbstractValidator<UpdateServiceStatusRequest>
    {
        public UpdateServiceStatusValidator() 
        {
            RuleFor(ss => ss.serviceStatusId).NotEmpty();
            RuleFor(ss => ss.statusName).NotEmpty();
        }
    }
}
