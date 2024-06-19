using FizzBuzzExcercise.Repository;
using Moq;
using static FizzBuzzExcercise.Models.FizzBuzzEntity;
using NUnit.Framework;
using Microsoft.AspNetCore.Mvc;

namespace UnitTestFizzBuzz
{
    [TestFixture]
    public class DivisionServiceTests
    {
        private Mock<IDivisionService> _mockDivisionService;
        private DivisionService _divisionService;

        [SetUp]
        public void Setup()
        {
            _mockDivisionService = new Mock<IDivisionService>();
            _divisionService = new DivisionService();
        }

        [Test]
        public void GetDivisionResult_InputIsMultipleOf3_ReturnsFizz()
        {
            // Arrange
            int input = 6; // Multiple of 3

            // Act
            var result = _divisionService.GetDivisionResult(input);

            // Assert
            Assert.That(DivisionResult.Fizz,Is.EqualTo(result));
        }
        [Test]
        public void GetDivisionResult_InputIsMultipleOf5_ReturnsBuzz()
        {
            // Arrange
            int input = 10; // Multiple of 5

            // Act
            var result = _divisionService.GetDivisionResult(input);

            // Assert
            Assert.That(DivisionResult.Buzz, Is.EqualTo(result));
        }
        [Test]
        public void GetDivisionResult_InputIsMultipleOf3and5_ReturnsFizzBuzz()
        {
            // Arrange
            int input = 15; // Multiple of 3 and 5

            // Act
            var result = _divisionService.GetDivisionResult(input);

            // Assert
            Assert.That(DivisionResult.FizzBuzz, Is.EqualTo(result));
        }
        [Test]
        public void GetDivisionResult_InputIs23_ReturnsValue()
        {
            // Arrange
            int input = 23;

            // Act
            var result = _divisionService.GetDivisionResult(input);

            // Assert
            Assert.That(DivisionResult.Value, Is.EqualTo(result));
        }


    }

}