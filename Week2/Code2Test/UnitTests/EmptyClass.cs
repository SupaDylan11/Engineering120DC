using Code2Test;


namespace UnitTests
{
    public class ClassificationTests
    {
        // boundry value tests
        //[Test]
        //public void GivenATimeOf4_Greeting_ReturnsGoodEvening()
        //{
        //    Assert.That(Program.Greeting(4), Is.EqualTo("Good Evening"));
        //}

        // test for each boundary & partition
        // that is (0 - 11)/ (12 - 14)/ (15 - 17)/ & (18+) - we aren't doing robust tests here.

        // without adult
        [TestCase(0, false, "U & PG films are available.")]
        [TestCase(11, false, "U & PG films are available.")]
        [TestCase(12, false, "U, PG & 12 films are available.")]
        [TestCase(14, false, "U, PG & 12 films are available.")]
        [TestCase(15, false, "U, PG, 12 & 15 films are available.")]
        [TestCase(17, false, "U, PG, 12 & 15 films are available.")]
        [TestCase(18, false, "All films are available.")]

        // with adult (this only affects ages below 12 - for the 12A rating)
        [TestCase(0, true, "U, PG & 12 films are available.")]
        [TestCase(11, true, "U, PG & 12 films are available.")]
        public void GivenUnaccompaniedAge_Result_AgeRating(int age, bool withAdult, string statement)
        {
            Assert.That(Program.CorrectedClassifications(age, withAdult),
                Is.EqualTo(statement));
        }

        // now for modified vershun
        // without adult
        [TestCase(0, false, "U & PG films are available.")]
        [TestCase(11, false, "U & PG films are available.")]
        [TestCase(12, false, "U, PG & 12 films are available.")]
        [TestCase(14, false, "U, PG & 12 films are available.")]
        [TestCase(15, false, "U, PG, 12 & 15 films are available.")]
        [TestCase(17, false, "U, PG, 12 & 15 films are available.")]
        [TestCase(18, false, "All films are available.")]

        // with adult (this only affects ages below 12 - for the 12A rating)
        [TestCase(0, true, "U, PG & 12 films are available.")]
        [TestCase(11, true, "U, PG & 12 films are available.")]
        public void AltGivenUnaccompaniedAge_Result_AgeRating(int age, bool withAdult, string statement)
        {
            Assert.That(Program.AltClassification(age, withAdult),
                Is.EqualTo(statement));
        }


    }
}

