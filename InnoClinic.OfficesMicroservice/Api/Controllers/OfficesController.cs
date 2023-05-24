using Api.Enums;
using Application.Commands.ChangeOfficeStatus;
using Application.Commands.CreateOffice;
using Application.Commands.UpdateOffice;
using Application.Queries.GetOfficeById;
using Application.Queries.GetOffices;
using Application.Queries.GetOfficesByIds;
using Domain.RequestParameters;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OfficesController(IMediator mediator)
        { 
            _mediator = mediator;
        }

        [Authorize(Roles = nameof(UserRole.Receptionist))]
        [HttpPost]
        public async Task<IActionResult> CreateOfficeAsync([FromBody] CreateOfficeCommand createCommand)
        {
            var res = await _mediator.Send(createCommand);
            return CreatedAtRoute("GetOffice", new { id = res }, res);
        }

        [Authorize(Roles = $"{nameof(UserRole.Patient)},{nameof(UserRole.Doctor)},{nameof(UserRole.Receptionist)}")]
        [HttpGet("list")]
        public async Task<IActionResult> GetOfficesAsync([FromQuery] OfficeParameters parameters)
        {
            var officesQuery = new GetOfficesQuery(parameters);
            var res = await _mediator.Send(officesQuery);
            return Ok(res);
        }

        [Authorize(Roles = $"{nameof(UserRole.Patient)},{nameof(UserRole.Doctor)},{nameof(UserRole.Receptionist)}")]
        [HttpPost("ids")]
        public async Task<IActionResult> GetOfficesByIdsAsync([FromBody] GetOfficesByIdsQuery officesQuery)
        {
            var res = await _mediator.Send(officesQuery);
            return Ok(res);
        }

        [Authorize(Roles = $"{nameof(UserRole.Patient)},{nameof(UserRole.Doctor)},{nameof(UserRole.Receptionist)}")]
        [HttpGet("office/{id}", Name = "GetOffice")]
        public async Task<IActionResult> GetOfficeByIdAsync(Guid id)
        {
            var officeQuery = new GetOfficeByIdQuery(id);
            var res = await _mediator.Send(officeQuery);
            return Ok(res);
        }

        [Authorize(Roles = $"{nameof(UserRole.Receptionist)}")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOfficeAsync(Guid id, [FromBody] UpdateOfficeCommand updateCommand)
        {
            updateCommand.Id = id;
            await _mediator.Send(updateCommand);
            return NoContent();
        }

        [Authorize(Roles = $"{nameof(UserRole.Receptionist)}")]
        [HttpPut("{id}/status")]
        public async Task<IActionResult> ChangeOfficeStatusAsync(Guid id, [FromBody] ChangeOfficeStatusCommand changeStatusCommand)
        {
            changeStatusCommand.Id = id;
            await _mediator.Send(changeStatusCommand);
            return NoContent();
        }
    }
}
