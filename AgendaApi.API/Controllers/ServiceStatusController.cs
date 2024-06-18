using AgendaApi.Application.UseCases.ServiceStatusUsecases.CreateServiceStatus;
using AgendaApi.Application.UseCases.ServiceStatusUsecases.DeleteServiceStatus;
using AgendaApi.Application.UseCases.ServiceStatusUsecases.GetAllServiceStatus;
using AgendaApi.Application.UseCases.ServiceStatusUsecases.UpdateServiceStatus;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AgendaApi.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiceStatusController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ServiceStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllServiceStatusResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new GetAllServiceStatusRequest(), cancellationToken);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<CreateServiceStatusResponse>> Create(CreateServiceStatusRequest request,
            CancellationToken cancellationToken)
        {
            if (request is null) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }

        [HttpDelete("{serviceStatusId:int}")]
        public async Task<ActionResult<DeleteServiceStatusResponse>> Delete(int? serviceStatusId, 
            CancellationToken cancellationToken)
        {
            if (serviceStatusId is null) return BadRequest();
            var result = await _mediator.Send(new DeleteServiceStatusRequest(serviceStatusId.Value), cancellationToken);
            return Ok(result);
        }

        [HttpPut("{serviceStatusId:int}")]
        public async Task<ActionResult<UpdateServiceStatusResponse>> Update(int? serviceStatusId, UpdateServiceStatusRequest request,
            CancellationToken cancellationToken)
        {
            if (serviceStatusId != request.serviceStatusId) return BadRequest();
            var result = await _mediator.Send(request, cancellationToken);
            return Ok(result);
        }
    }
}
