using AgendaApi.Application.UseCases.LegalPersonUseCases.CreateLegalEntity;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LegalEntityController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LegalEntityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<CreateLegalEntityResponse>> Create(CreateLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            var validator = new CreateLegalEntityValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (!validationResult.IsValid) return BadRequest(validationResult.Errors);

            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
