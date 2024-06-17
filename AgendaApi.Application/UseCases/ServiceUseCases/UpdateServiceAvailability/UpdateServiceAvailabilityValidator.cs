using FluentValidation;

namespace AgendaApi.Application.UseCases.ServiceUseCases.UpdateServiceAvailability
{
    public class UpdateServiceAvailabilityValidator : AbstractValidator<UpdateServiceAvailabilityRequest>
    {
        public UpdateServiceAvailabilityValidator() 
        {
            RuleFor(s => s.serviceStatusId).NotEmpty()
                .InclusiveBetween(1, 2);
        }
    }
}
