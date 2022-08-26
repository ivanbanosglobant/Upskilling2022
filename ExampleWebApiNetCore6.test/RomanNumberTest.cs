using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWebApiNetCore6.test
{
    public class RomanNumberTest
    {
        RomanNumber _sut;

        [Test]
        public void Given1_WhenConverting_thenGetI()
        {
            //Arrange
            _sut = new RomanNumber();
            var number = 1;
            //Act
            var result = _sut.Convert(number);
            //Assert
            Assert.AreEqual("I", result);
        }

        [Test]
        public void Given2_WhenConverting_thenGetII()
        {
            //Arrange
            _sut = new RomanNumber();
            var number = 2;
            //Act
            var result = _sut.Convert(number);
            //Assert
            Assert.AreEqual("II", result);
        }

        [Test]
        public void Given3_WhenConverting_thenGetIII()
        {
            //Arrange
            _sut = new RomanNumber();
            var number = 3;
            //Act
            var result = _sut.Convert(number);
            //Assert
            Assert.AreEqual("III", result);
        }

        [Test]
        public void Given4_WhenConverting_thenGetIV()
        {
            //Arrange
            _sut = new RomanNumber();
            var number = 4;
            //Act
            var result = _sut.Convert(number);
            //Assert
            Assert.AreEqual("IV", result);
        }

        [Test]
        public void Given5_WhenConverting_thenGetV()
        {
            //Arrange
            _sut = new RomanNumber();
            var number = 5;
            //Act
            var result = _sut.Convert(number);
            //Assert
            Assert.AreEqual("V", result);
        }

        [Test]
        public void Given6_WhenConverting_thenGetVI()
        {
            //Arrange
            _sut = new RomanNumber();
            var number = 6;
            //Act
            var result = _sut.Convert(number);
            //Assert
            Assert.AreEqual("VI", result);
        }
    }
}
