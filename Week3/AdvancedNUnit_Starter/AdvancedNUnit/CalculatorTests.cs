using NUnit.Framework;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    public class CalculatorTests
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void Add_Always_ReturnsExpectedResult()
        {
            // Arrange
            var expectedResult = 6;
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            // Act
            var result = subject.Add();
            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "optional failure message");
        }

        [Test]
        public void SomeConstraints()
        {
            var _sut = new Calculator { Num1 = 6 };
            Assert.That(_sut.DivisibleBy3());

            _sut.Num1 = 7;
            Assert.That(_sut.DivisibleBy3(), Is.False);

            Assert.That(_sut.ToString(), Does.Contain("Calculator"));
        }

        [Test]
        public void StringConstraints_YetAnotherTerribleTestName()
        {
            var subject = new Calculator { Num1 = 2, Num2 = 4 };
            var strResult = subject.ToString();

            Assert.That(strResult, Is.EqualTo("AdvancedNUnit.Calculator"));
            Assert.That(strResult, Does.Contain("Calculator"));
            Assert.That(strResult == "AdvancedNUnit.Calculator");
            Assert.That(strResult, Does.Not.Contain("bitch lasagne"));
            Assert.That(strResult, Is.Not.Empty);
        }
    }
    
}