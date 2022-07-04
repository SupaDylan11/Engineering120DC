using Code2Test;

namespace UnitTests;

public class Tests
{
    [Test]
    public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
    {
        Assert.That(Program.Greeting(21), Is.EqualTo("Good Evening"));
    }

    [Test]
    public void GivenATimeOf15_Greeting_ReturnsGoodAfternoon()
    {
        Assert.That(Program.Greeting(15), Is.EqualTo("Good Afternoon"));
    }

    [Test]
    public void GivenATimeOf2_Greeting_ReturnsGoodEvening()
    {
        Assert.That(Program.Greeting(2), Is.EqualTo("Good Evening"));
    }

    [Test]
    public void GivenATimeOf8_Greeting_ReturnsGoodAfternoon()
    {
        Assert.That(Program.Greeting(8), Is.EqualTo("Good Morning"));
    }


    // boundry value tests
    //[Test]
    //public void GivenATimeOf4_Greeting_ReturnsGoodEvening()
    //{
    //    Assert.That(Program.Greeting(4), Is.EqualTo("Good Evening"));
    //}

    //[Test]
    //public void GivenATimeOf5_Greeting_ReturnsGoodMorning()
    //{
    //    Assert.That(Program.Greeting(5), Is.EqualTo("Good Morning"));
    //}
    //[Test]

    //public void GivenATimeOf11_Greeting_ReturnsGoodMorning()
    //{
    //    Assert.That(Program.Greeting(11), Is.EqualTo("Good Morning"));
    //}

    //[Test]
    //public void GivenATimeOf12_Greeting_ReturnsGoodAfternoon()
    //{
    //    Assert.That(Program.Greeting(12), Is.EqualTo("Good Afternoon"));
    //}

    //[Test]
    //public void GivenATimeOf18_Greeting_ReturnsGoodAfternoon()
    //{
    //    Assert.That(Program.Greeting(18), Is.EqualTo("Good Afternoon"));
    //}

    //[Test]
    //public void GivenATimeOf19_Greeting_ReturnsGoodEvening()
    //{
    //    Assert.That(Program.Greeting(19), Is.EqualTo("Good Evening"));
    //}

    //refined boundary tests
    
    [TestCase(5)]
    [TestCase(11)]
    public void GivenATimeOfBetween5and11_Greeting_ReturnsGoodMorning(int time)
    {
        Assert.That(Program.Greeting(time), Is.EqualTo("Good Morning"));
    }

    [TestCase(12)]
    [TestCase(18)]
    public void GivenATimeOfBetween12and18_Greeting_ReturnsGoodAfternoon(int time)
    {
        Assert.That(Program.Greeting(time), Is.EqualTo("Good Afternoon"));
    }

    [TestCase(19)]
    [TestCase(4)]
    public void GivenATimeOfBetween19and4_Greeting_ReturnsGoodMorning(int time)
    {
        Assert.That(Program.Greeting(time), Is.EqualTo("Good Evening"));
    }


    // two pararmeters
    [TestCase(5, "Good Morning")]
    [TestCase(11, "Good Morning")]
    [TestCase(12, "Good Afternoon")]
    [TestCase(18, "Good Afternoon")]
    [TestCase(19, "Good Evening")]
    [TestCase(4, "Good Evening")]
    public void GivenAtTimeAndGreeting(int time, string greeting)
    {
        Assert.That(Program.Greeting(time), Is.EqualTo(greeting));
    }

}
