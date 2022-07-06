using WeightApp;

namespace StoneTests;

public class SelectionTests
{
    
    [TestCase(100, "Distinction")]
    [TestCase(90, "Distinction")]
    [TestCase(85, "Distinction")]
    public void GivenAMarkOver85_Return_Distinction(int mark, string expectedResult)
    {
        Assert.That(TestGrade.GetGrade(mark), Is.EqualTo(expectedResult));
    }

    [TestCase(84, "Pass")]
    [TestCase(70, "Pass")]
    [TestCase(65, "Pass")]
    public void GivenAMarkBetween84and65Inclusive_Return_Pass(int mark, string expectedResult)
    {
        Assert.That(TestGrade.GetGrade(mark), Is.EqualTo(expectedResult));
    }

    [TestCase(64, "Fail with retake")]
    [TestCase(40, "Fail with retake")]
    [TestCase(21, "Fail with retake")]
    public void GivenAMarkBetween64and21Inclusive_Return_Distinction(int mark, string expectedResult)
    {
        Assert.That(TestGrade.GetGrade(mark), Is.EqualTo(expectedResult));
    }

    [TestCase(20, "Fail no retake")]
    [TestCase(10, "Fail no retake")]
    [TestCase(0, "Fail no retake")]
    public void GivenAMarkunderInclusive_Return_Distinction(int mark, string expectedResult)
    {
        Assert.That(TestGrade.GetGrade(mark), Is.EqualTo(expectedResult));
    }
}