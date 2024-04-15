using MediatR;
using Medical.Attendance.Application.Events.ScheduleEvents.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Medical.Attendance.Api.Controllers.V1
{
    [Route("api/v1/schedule")]
    [ApiController]
    public class ScheduleController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] GetScheduleCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
