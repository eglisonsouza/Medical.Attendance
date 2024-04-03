﻿using MediatR;
using Medical.Attendance.Application.Events.ConfigEvents.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Medical.Attendance.Api.Controllers.V1
{
    [ApiController]
    [Route("api/v1/config")]
    public sealed class ConfigController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpPost]
        public async Task<IActionResult> AddAsync(AddConfigCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpGet]
        public async Task<IActionResult> GetAsync([FromQuery] GetConfigCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
