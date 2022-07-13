using NUnit.Framework;
using System;
using Methods_Lib;

namespace Methods_Tests
{
    public class DiceTests
    {
        public void GivenARandomNumber_ReturnsAVauleBetween1and12()
        {
            Assert.That(Methods.RollDice(new Random()), Is.AtLeast(1));
            Assert.That(Methods.RollDice(new Random()), Is.AtMost(12));
        }
    }
}
