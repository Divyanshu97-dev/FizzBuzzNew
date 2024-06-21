using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using FizzBuzzExcercise.Repository;

[TestFixture]
public class DivisionServiceTests
{
    private IDivisionService _divisionService;
    private Mock<IDivisionService> _mockDivisionService;

    [SetUp]
    public void Setup()
    {
        _divisionService = new DivisionService();
        _mockDivisionService = new Mock<IDivisionService>();
    }



    [Test]
    public void Test_ProcessList_With_EmptyInput()
    {
        // Arrange
        List<string> inputList = new List<string> { "" };
        string expectedresult = "Invalid item";

        // Act
        List<string> result = _divisionService.GetDivisionResult(inputList);

        // Assert

        Assert.That(expectedresult, Is.EqualTo( result[0]));
    }

    [Test]
    public void Test_ProcessList_With_NonNumericString()
    {
        // Arrange
        List<string> inputList = new List<string> { "A" };
        string expectedresult = "Invalid item";

        // Act
        List<string> result = _divisionService.GetDivisionResult(inputList);

        // Assert

        Assert.That(expectedresult, Is.EqualTo(result[0]));
    }

    [Test]
    public void Test_ProcessList_With_3()
    {
        // Arrange
        List<string> inputList = new List<string> { "3" };
        string expectedresult = "Fizz";

        // Act
        List<string> result = _divisionService.GetDivisionResult(inputList);

        // Assert
        
        Assert.That(expectedresult, Is.EqualTo(result[0]));
    }

    [Test]
    public void Test_ProcessList_With_5()
    {
        // Arrange
        List<string> inputList = new List<string> { "5" };
        string expectedresult = "Buzz";

        // Act
        List<string> result = _divisionService.GetDivisionResult(inputList);

        // Assert
      
        Assert.That(expectedresult, Is.EqualTo(result[0]));
    }

    [Test]
    public void Test_ProcessList_With_MultipleOf3And5()
    {
        // Arrange
        List<string> inputList = new List<string> { "15","30" };
        string expectedresult = "FizzBuzz";
        // Act
        List<string> result = _divisionService.GetDivisionResult(inputList);

        // Assert
        
        Assert.That(expectedresult, Is.EqualTo(result[0]));
        Assert.That(expectedresult, Is.EqualTo(result[1]));
    }

    [Test]
    public void Test_ProcessList_With_NumberNotDivisibleBy23()
    {
        // Arrange
        List<string> inputList = new List<string> { "23" };
        string expectedresult = "23/3 = 7 and 23/5 = 4";

        // Act
        List<string> result = _divisionService.GetDivisionResult(inputList);

        // Assert
        
        Assert.That(expectedresult,Is.EqualTo( result[0]));
        
    }
    [Test]
    public void Test_ProcessList_With_NumberNotDivisibleBy1()
    {
        // Arrange
        List<string> inputList = new List<string> { "1" };
        string expectedresult = "1/3 = 0 and 1/5 = 0";

        // Act
        List<string> result = _divisionService.GetDivisionResult(inputList);

        // Assert
        
        Assert.That(expectedresult, Is.EqualTo(result[0]));

    }
}
