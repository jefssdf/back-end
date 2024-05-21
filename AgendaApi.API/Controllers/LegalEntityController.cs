using AgendaApi.Application.UseCases.LegalPersonUseCases.CreateLegalEntity;
using AgendaApi.Application.UseCases.LegalPersonUseCases.GetAllLegalEntity;
using AgendaApi.Application.UseCases.LegalPersonUseCases.UpdateLegalEntity;
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
        [HttpGet]
        public async Task<ActionResult<List<GetAllLegalEntityResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllLegalEntityRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateLegalEntityResponse>> Create(CreateLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UpdateLegalEntityResponse>> Update(Guid id, 
            UpdateLegalEntityRequest request, CancellationToken cancellationToken)
        {
            if (id != request.Id) return BadRequest();

            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
    }
}
