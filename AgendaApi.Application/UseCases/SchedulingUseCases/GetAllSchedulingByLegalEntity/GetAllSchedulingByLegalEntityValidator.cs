﻿using AgendaApi.Application.Shared.GlobalValidators;
using FluentValidation;

namespace AgendaApi.Application.UseCases.SchedulingUseCases.GetAllSchedulingByLegalEntity
{
    public class GetAllSchedulingByLegalEntityValidator : AbstractValidator<GetAllSchedulingByLegalEntityRequest>
    {
        public GetAllSchedulingByLegalEntityValidator() 
        {
            RuleFor(s => s.legalEntityId).NotEmpty().NotNull()
                .Must(GuidValidator.BeValid);
        }
    }
}
