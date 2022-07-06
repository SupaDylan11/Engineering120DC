using WeightApp;

namespace StoneTests;

public class UnitTest1
{
    [TestCase(13, 0)]
    [TestCase(14, 1)]
    [TestCase(27, 1)]
    [TestCase(28, 2)]
    public void GivenPounds_Return_CorrectStones(int pounds, int expectedStones)
    {
        Assert.That(Methods.GetStones(pounds), Is.EqualTo(expectedStones));
    }

    [TestCase(13, 13)]
    [TestCase(14, 0)]
    [TestCase(15, 1)]
    [TestCase(20, 6)]
    [TestCase(28, 0)]
    public void GivenPounds_Return_CorrectPoundsRemainders(int pounds, int expectedStones)
    {
        Assert.That(Methods.GetPounds(pounds), Is.EqualTo(expectedStones));
    }

    [Test]
    public void GivenANegativeValue_Return_ZeroStone()
    {
        Assert.That(Methods.GetStones(-2), Is.EqualTo(0));
    }

    [Test]
    public void GivenANegativeValue_Return_ZeroPound()
    {
        Assert.That(Methods.GetPounds(-2), Is.EqualTo(0));
    }
}
