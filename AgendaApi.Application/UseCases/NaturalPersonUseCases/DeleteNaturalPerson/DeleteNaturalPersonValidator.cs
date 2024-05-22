using FluentValidation;

namespace AgendaApi.Application.UseCases.NaturalPersonUseCases.DeleteNaturalPerson
{
    public class DeleteNaturalPersonValidator : AbstractValidator<DeleteNaturalPersonRequest>
    {
        public DeleteNaturalPersonValidator() 
        {
            RuleFor(np => np.id).NotEmpty();
        }
    }
}
