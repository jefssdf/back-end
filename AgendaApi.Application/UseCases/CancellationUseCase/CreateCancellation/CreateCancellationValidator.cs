using FluentValidation;

namespace AgendaApi.Application.UseCases.CancellationUseCase.CreateCancellation
{
    public class CreateCancellationValidator : AbstractValidator<CreateCancellationRequest>
    {
        public CreateCancellationValidator() 
        {
            RuleFor(c => c.cancellationTime).NotEmpty()
                .LessThan(DateTime.Now)
                .WithMessage("O cancelamento não pode ser feito em uma data no passado.");
            RuleFor(c => c.owner).NotEmpty();
        }
    }
}



/*
 DateTime? cancellationTime, 
                Guid owner, 
                Guid? schedulingId
 */