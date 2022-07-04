﻿using Code2Test;


namespace UnitTests
{
    public class ClassificationTests
    {
        [TestCase(0, false, "U & PG films are available.")]
        [TestCase(11, false, "U & PG films are available.")]
        public void GivenUnaccompaniedUnder12_Result_UandPG(int age, bool withAdult, string expectedResult)
        {
            Assert.That(Program.AltClassification(age, withAdult),
                Is.EqualTo(expectedResult));
        }


        [TestCase(0, true, "U, PG & 12 films are available.")]
        [TestCase(11, true, "U, PG & 12 films are available.")]
        public void GivenAccompaniedUnder12_Result_U_PGand12(int age, bool withAdult, string expectedResult)
        {
            Assert.That(Program.AltClassification(age, withAdult),
                Is.EqualTo(expectedResult));
        }

        [TestCase(12, false, "U, PG & 12 films are available.")]
        [TestCase(14, false, "U, PG & 12 films are available.")]
        public void GivenUnder15_Result_U_PGand12(int age, bool withAdult, string expectedResult)
        {
            Assert.That(Program.AltClassification(age, withAdult),
                Is.EqualTo(expectedResult));
        }

        [TestCase(15, false, "U, PG, 12 & 15 films are available.")]
        [TestCase(17, false, "U, PG, 12 & 15 films are available.")]
        public void GivenUnder18_Result_U_PG_12and15(int age, bool withAdult, string expectedResult)
        {
            Assert.That(Program.AltClassification(age, withAdult),
                Is.EqualTo(expectedResult));
        }

        [TestCase(18, false, "All films are available.")]
        public void Given18orUp_Result_AllFilms(int age, bool withAdult, string expectedResult)
        {
            Assert.That(Program.AltClassification(age, withAdult),
                Is.EqualTo(expectedResult));
        }
    }
}

