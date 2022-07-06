using NUnit.Framework;
using TestFirstExercises;

namespace TestFirstExercises_Tests
{
    public class CheckInputTests
    {
        [TestCase("PASSWORD")]
        [TestCase("password")]
        [TestCase("PaSswORd")]
        [TestCase("pASSwORD")]
        public void GivenTheStringPassword_RegardlessOfCase_CheckInput_ReturnsTrue(string str )
        {
            bool result = Methods.CheckInput(str);
            Assert.That(result);
        }

        [TestCase("PASS")]
        [TestCase("word")]
        [TestCase("Chicken")]
        [TestCase("")]
        [TestCase("PaSSw0rD")]
        [TestCase("Passwerd")]
        public void GivenAnyStringExceptPassword_CheckInput_ReturnsFalse(string str)
        {
            bool result = Methods.CheckInput(str);
            Assert.That(result, Is.False);
        }
    }
}
