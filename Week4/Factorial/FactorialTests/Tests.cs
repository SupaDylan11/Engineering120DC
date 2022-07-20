using FactorialApp;

namespace FactorialTests
{
    public class Tests
    {
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 6)]
        [TestCase(5, 120)]
        public void GivenNumber_Factorial_ReturnsExpectedResult(int n, int expectedResult)
        {
            Assert.That(Program.Factorial(n), Is.EqualTo(expectedResult));
        }

        [Test]
        public void GivenNegativeNumber_Factorial_ThrowsArgumentOutOfRangeException()
        {
            Assert.That(() => Program.Factorial(-1), Throws.TypeOf<ArgumentOutOfRangeException>()); ;
        }
    }
}