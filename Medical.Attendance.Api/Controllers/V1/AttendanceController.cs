using MediatR;
using Medical.Attendance.Application.Events.AttendanceEvents.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Medical.Attendance.Api.Controllers.V1
{
    [ApiController]
    [Route("api/v1/attendance")]
    public class AttendanceController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        public async Task<IActionResult> PostAsync(AddAttendanceCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
