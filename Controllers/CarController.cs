using ExampleWebApiNetCore6.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace ExampleWebApiNetCore6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        [HttpPost]
        [Route("AddCar")]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> AddCar(Car car)
        {
            return Ok($"Car {JsonConvert.SerializeObject(car)} Added");
        }

        [HttpGet("GetCar/{plate}")]
        [ProducesResponseType(typeof(Car), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetCar(string plate)
        {
            var car = new Car() { Plate = "KJZ881", User = "Ivan Baños" };
            return Ok(car);
        }
    }
}
