using ExampleWebApiNetCore6.Application.Command;
using ExampleWebApiNetCore6.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ExampleWebApiNetCore6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("SaveUser")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> SaveUser(User user, CancellationToken cancellationToken)
        {
            var command = new SaveUserCommand(user);
            await _mediator.Send(command, cancellationToken);
            return Ok();
        }
    }
}
