using SortingAlgos;

namespace BubbleTest;

public class Tests
{
    [Category("Single Value In Array")]
    [Test]
    public void GivenASingleValue_Return_SingleValue()
    {
        var array = new int[1];
        array[0] = 5;
        Assert.That(BubbleSort.Sort(array), Is.EqualTo(array));
    }

    [Category("Double Values In Array")]
    [TestCase()]
    public void Test1()
    {
        Assert.Pass();
    }


    [Category("Bubble Sorting")]
    [Test]
    [Ignore("f")]
    public void Test2()
    {
        Assert.Pass();
    }
}
