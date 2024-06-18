using AgendaApi.Application.UseCases.ServiceUseCase.CreateService;
using AgendaApi.Application.UseCases.ServiceUseCase.GetAllService;
using AgendaApi.Application.UseCases.ServiceUseCase.GetServiceById;
using AgendaApi.Application.UseCases.ServiceUseCase.UpdateService;
using AgendaApi.Application.UseCases.ServiceUseCases.GetServiceByLegalEntityId;
using AgendaApi.Application.UseCases.ServiceUseCases.UpdateServiceAvailability;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ServiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("LegalEntityServices/{legalEntityId:Guid}")]
        public async Task<ActionResult<List<GetAllServiceResponse>>> 
            GetAll(Guid? legalEntityId, CancellationToken cancellationToken)
        {
            if (legalEntityId is null) return BadRequest();
            var result = await _mediator.Send(new GetAllServiceRequest(legalEntityId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpGet("{serviceId:Guid}")]
        public async Task<ActionResult<GetServiceByIdResponse>> GetById(Guid? serviceId,
            CancellationToken cancellationToken)
        {
            if (serviceId is null) return BadRequest();
            var result = await _mediator.Send(new GetServiceByIdRequest(serviceId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpGet("LegalEntityId/{legalEntityId:Guid}")]
        public async Task<ActionResult<List<GetServiceByLegalEntityIdResponse>>> GetByLegalEntityId(Guid? legalEntityId,
            CancellationToken cancellationToken)
        {
            if (legalEntityId is null) return BadRequest();
            var result = await _mediator.Send(new GetServiceByLegalEntityIdRequest(legalEntityId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateServiceResponse>> Create(CreateServiceRequest request,
            CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpPut("{serviceId:Guid}")]
        public async Task<ActionResult<UpdateServiceResponse>> Update(Guid? serviceId,
            UpdateServiceRequest request, CancellationToken cancellationToken)
        {
            if (serviceId != request.serviceId) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpPut("availability/{serviceId:Guid}")]
        public async Task<ActionResult<UpdateServiceAvailabilityResponse>> UpdateAvailability(Guid? serviceId,
            UpdateServiceAvailabilityRequest request, CancellationToken cancellationToken)
        {
            if (serviceId != request.serviceId) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
    }
}
