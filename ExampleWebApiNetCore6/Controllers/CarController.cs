using ExampleWebApiNetCore6.DbInterface;
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
        private readonly IDataBaseHandler _dataBaseHandler;

        public CarController(IDataBaseHandler dataBaseHandler)
        {
            _dataBaseHandler = dataBaseHandler;
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
        public async Task<Car> GetCar(string plate)
        {
            //var car = new Car() { Plate = "KJZ881", User = "Ivan Baños" };
            var car = await _dataBaseHandler.GetCarBayPlate(plate);
            return car;
        }
    }
}
