using System;
using NUnit.Framework;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    class SumEvenFiveTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(9, 25)]
        [TestCase(10, 35)]
        [TestCase(22, 152 )]
        public void SumEvenFive_ReturnsExpectedResult(int n, int expectedSum)
        {
            var result = Methods.SumEvenFive(n);
            Assert.That(result, Is.EqualTo(expectedSum));
        }
        [Test]
        public void GivenAParameterOfZero_SumEvenFive_ReturnsZero()
        {
            var result = Methods.SumEvenFive(0);
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void GivenANegativeParameter_SumEvenFive_ReturnsZero()
        {
            var result = Methods.SumEvenFive(-3);
            Assert.That(result, Is.EqualTo(0));
        }

        [TestCase(5, 11)]
        [TestCase(10, 35)]
        [TestCase(15, 76)]
        [TestCase(20, 130)]
        [TestCase(25, 201)]
        public void GivenFirst5MultipleOfFives_eturnExpectedResult(int n, int expectedSum)
        {
            var result = Methods.SumEvenFive(n);
            Assert.That(result, Is.EqualTo(expectedSum));
        }

        [TestCase(2, 2)]
        [TestCase(4, 6)]
        [TestCase(6, 17)]
        [TestCase(8, 25)]
        [TestCase(10, 35)]
        public void GivenFirst5MultipleOfTwos_ReturnExpectedResult(int n, int expectedSum)
        {
            var result = Methods.SumEvenFive(n);
            Assert.That(result, Is.EqualTo(expectedSum));
        }
    }
}
