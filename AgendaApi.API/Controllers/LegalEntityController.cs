using AgendaApi.Application.UseCases.LegalPersonUseCases.CreateLegalEntity;
using AgendaApi.Application.UseCases.LegalPersonUseCases.DeleteLegalEntity;
using AgendaApi.Application.UseCases.LegalPersonUseCases.GetAllLegalEntity;
using AgendaApi.Application.UseCases.LegalPersonUseCases.GetLegalEntityByEmail;
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
        public async Task<ActionResult<List<GetAllLegalEntityResponse>>> 
            GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllLegalEntityRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpGet("{email}")]
        public async Task<ActionResult<GetLegalEntityByEmailResponse>> GetByEmail(string email,
            CancellationToken cancellationToken)
        {
            if (email is null) return BadRequest();

            var response = await _mediator.Send(new GetLegalEntityByEmailRequest(email), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<CreateLegalEntityResponse>> Create(CreateLegalEntityRequest request,
            CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpPut("{legalEntityId:Guid}")]
        public async Task<ActionResult<UpdateLegalEntityResponse>> Update(Guid legalEntityId, 
            UpdateLegalEntityRequest request, CancellationToken cancellationToken)
        {
            if (legalEntityId != request.id) return BadRequest();

            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpDelete("{legalEntityId:Guid}")]
        public async Task<ActionResult<DeleteLegalEntityResponse>> Delete(Guid? legalEntityId,
            CancellationToken cancellationToken)
        {
            if (legalEntityId is null) return BadRequest();

            var response = await _mediator.Send(new DeleteLegalEntityRequest(legalEntityId.Value), cancellationToken);
            return Ok(response);
        }
    }
}
