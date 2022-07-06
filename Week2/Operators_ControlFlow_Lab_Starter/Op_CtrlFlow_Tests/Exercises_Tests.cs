using NUnit.Framework;
using Op_CtrlFlow;
using System;
using System.Collections.Generic;

namespace Op_CtrlFlow_Tests
{
    public class Exercises_Tests
    {
        // write unit test(s) for MyMethod here
        [TestCase(100, 100)]
        [TestCase(40, 40)]
        [TestCase(20, 20)]
        [TestCase(15, 15)]
        [TestCase(80, 80)]
        public void GivenTwoEqualNumbers_ReturnFalse(int num1, int num2)
        {
            var result = Exercises.MyMethod(num1, num2);
            Assert.That(result, Is.EqualTo(false));
        }

        // write unit test(s) for MyMethod here
        [TestCase(100, 40)]
        [TestCase(20, 15)]
        [TestCase(15, 80)]
        [TestCase(80, 100)]
        public void GivenTwoUnequalNonDivisibleNumbers_ReturnFalse(int num1, int num2)
        {
            var result = Exercises.MyMethod(num1, num2);
            Assert.That(result, Is.EqualTo(false));
        }

        // write unit test(s) for MyMethod here
        [TestCase(100, 5)]
        [TestCase(200, 50)]
        [TestCase(15, 3)]
        [TestCase(80, 40)]
        public void GivenTwoUnequalDivisibleNumbers_ReturnTrue(int num1, int num2)
        {
            var result = Exercises.MyMethod(num1, num2);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Average_ReturnsCorrectAverage()
        {
            var myList = new List<int>() { 3, 8, 1, 7, 3 };
            Assert.That(Exercises.Average(myList), Is.EqualTo(4.4));
        }

        [Test]
        public void WhenListIsEmpty_ThrowsNullReferenceException()
        {
            var myList = new List<int>() {};
            Assert.That(() => Exercises.Average(myList), Throws.TypeOf<NullReferenceException>());
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void TicketTypeTest(int age, string expected)
        {
            var result = Exercises.TicketType(age);
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(100, "OAP")]
        [TestCase(60, "OAP")]
        [TestCase(59, "Standard")]
        [TestCase(18, "Standard")]
        [TestCase(17, "Student")]
        [TestCase(13, "Student")]
        [TestCase(12, "Child")]
        [TestCase(5, "Child")]
        [TestCase(4, "Free")]
        [TestCase(0, "Free")]
        public void GivenASetAge_ReturnTheExpectedTicket(int age, string expectedTicket)
        {
            var result = Exercises.TicketTypeRefactored(age);
            Assert.That(result, Is.EqualTo(expectedTicket));
        }

        [TestCase(4, 20)]
        [TestCase(3, 50)]
        [TestCase(2, 50)]
        [TestCase(1, 100)]
        [TestCase(0, 200)]
        public void GivenACovidLevel_ReturnMaxWeddingGuests(int covidLevel, int expectedMaxAttendees)
        {
            var result = Exercises.GetScottishMaxWeddingNumbers(covidLevel);
            Assert.That(result, Is.EqualTo(expectedMaxAttendees));
        }

        [TestCase(100)]
        [TestCase(99)]
        [TestCase(80)]
        [TestCase(76)]
        [TestCase(75)]
        public void GivenAMarkBetween75and100_Result_ReturnPassWithDistinction(int mark)
        {
            var result = Exercises.Grade(mark);
            Assert.That(result, Is.EqualTo("Pass with Distinction"));
        }

        [TestCase(74)]
        [TestCase(73)]
        [TestCase(65)]
        [TestCase(61)]
        [TestCase(60)]
        public void GivenAMarkBetween60and74_Result_ReturnPassWithMerit(int mark)
        {
            var result = Exercises.Grade(mark);
            Assert.That(result, Is.EqualTo("Pass with Merit"));
        }

        [TestCase(59)]
        [TestCase(58)]
        [TestCase(50)]
        [TestCase(41)]
        [TestCase(40)]
        public void GivenAMarkBetween40and59_Result_ReturnPass(int mark)
        {
            var result = Exercises.Grade(mark);
            Assert.That(result, Is.EqualTo("Pass"));
        }

        [TestCase(39)]
        [TestCase(38)]
        [TestCase(20)]
        [TestCase(1)]
        [TestCase(0)]
        public void GivenAMarkBetween0and39_Result_ReturnFail(int mark)
        {
            var result = Exercises.Grade(mark);
            Assert.That(result, Is.EqualTo("Fail"));
        }

        [TestCase(-1)]
        [TestCase(-23)]
        [TestCase(101)]
        [TestCase(200)]
        public void GivenAnOutOfRangeMark_ThrowsArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Exercises.Grade(mark), Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [TestCase(-1)]
        [TestCase(-2)]
        [TestCase(5)]
        [TestCase(69)]
        public void GivenAnOutOfRangeConvidLevel_ThrowsArgumentOutOfRangeException(int covidLevel)
        {
            Assert.That(() => Exercises.GetScottishMaxWeddingNumbers(covidLevel),
                Throws.TypeOf<ArgumentOutOfRangeException>());
        }
    }
}
