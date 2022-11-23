using ExampleWebApiNetCore6.Controllers;
using ExampleWebApiNetCore6.DataBase.DbInterface;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWebApiNetCore6.test
{
    public class CarControllerTest
    {
        //private readonly CarController _sut;
        //private readonly Mock<IDataBaseHandler> _dataBaseHandlerMock;

        //public CarControllerTest()
        //{
        //    _dataBaseHandlerMock = new Mock<IDataBaseHandler>();
        //    _sut = new CarController(_dataBaseHandlerMock.Object);
        //}

        //[Test]
        //public async Task GivenAplate_WhenCallingEndpoint_ThenGetCar()
        //{
        //    //Arrange
        //    var plate = "whatever";
        //    _dataBaseHandlerMock.Setup(x => x.GetCarBayPlate(It.IsAny<string>())).ReturnsAsync(new Models.Car() { Driver= "Ivan Baños" });
        //    //Act
        //    var result = await _sut.GetCar(plate, default);
        //    //Assert
        //    //Assert.AreEqual("Ivan Baños", result.Driver);
        //    _dataBaseHandlerMock.Verify(x => x.GetCarBayPlate(It.IsAny<string>()), Times.AtLeast(2));
        //}
    }
}
