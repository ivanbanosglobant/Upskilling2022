
using ExampleWebApiNetCore6.Application.Queries;
using ExampleWebApiNetCore6.Domain.Exceptions;
using ExampleWebApiNetCore6.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace ExampleWebApiNetCore6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("AddCar")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddCar(Car car)
        {
            return Ok($"Car {JsonConvert.SerializeObject(car)} Added");
        }

        [HttpGet("GetCar/{plate}")]
        [ProducesResponseType(typeof(Car), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCar(string plate, CancellationToken cancellationToken)
        {
            var car = await _mediator.Send(new GetCarByPlateQuery(plate), cancellationToken);
            return Ok(car);
        }
    }
}
