using NUnit.Framework;
using Methods_Lib;
using System;

namespace Methods_Tests
{
    public class TuplesTests
    {
        [TestCase(25, 3, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(33, 4, 5)]
        public void GivenANumber_DaysAndWeeks_ReturnsCorrectTuple(
            int totalDays, int expectedWeeks, int expectedDays)
        {
            var answer = Methods.DaysAndWeeks(totalDays);
            Assert.That(answer.weeks, Is.EqualTo(expectedWeeks), "Weeks");
            Assert.That(answer.days, Is.EqualTo(expectedDays), "Days");
        }
        [Test]
        public void GivenANegativeNumber_DaysAndWeeks_ThrowsAnException()
        {
            Assert.That(() => Methods.DaysAndWeeks(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("totalDays must not be negative"));
        }

        [TestCase(25, 625, 15625, 5.0)]
        [TestCase(1, 1, 1, 1.0)]
        [TestCase(4, 16, 64, 2)]
        public void GivenAnInteger_SquaresCubesAndSquareRoots_ReturnsCorrectTuple(
            int input, int expectedSquare, int expectedCube, double expectedSqrRoot)
        {
            (int square, int cube, double sqrRoot) answer = Methods.PowersRoot(input);
            Assert.That(answer, Is.EqualTo((expectedSquare, expectedCube, expectedSqrRoot)));
        }

        [Test]
        public void GivenANegativeNumber_PowerRoot_ThrowsAnException()
        {
            Assert.That(() => Methods.PowersRoot(-1), Throws.TypeOf<ArgumentOutOfRangeException>()
        .With.Message.Contain("Square number must not be negative"));
        }
    }
}