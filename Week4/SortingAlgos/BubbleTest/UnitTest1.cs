using SortingAlgos;

namespace BubbleTest;

public class Tests
{
    //[Category("Null Array")]
    //[Test]
    //public void GivenEmptyValue_Return_SingleValue()
    //{
    //    int[] array;
    //    Assert.That(BubbleSort.Sort(array), Is.EqualTo(array));
    //}

    [Category("Empty Array")]
    [Test]
    public void GivenEmptyValue_Return_SingleValue()
    {
        var array = new int[0];
        Assert.That(BubbleSort.Sort(array), Is.EqualTo(array));
    }

    [Category("Single Value In Array")]
    [Test]
    public void GivenASingleValue_Return_SingleValue()
    {
        var array = new int[1];
        array[0] = 5;
        Assert.That(BubbleSort.Sort(array), Is.EqualTo(array));
    }

    [TestCaseSource("AddCases")]
    [Category("Double Values In Array")]
    public void GivenTwoValues_BubbleSort_ReturnsExpectedResult(int[] input, int[] sortedArray)
    {
        Assert.That(BubbleSort.Sort(input), Is.EqualTo(sortedArray));
    }

    public static object[] AddCases =
    {
        new int[][] { new int[] { 1, 2 }, new int[] { 1, 2 } },
        new int[][] { new int[] { 2, 1 }, new int[] { 1, 2 } }
    };


    [TestCaseSource("AddCases2")]
    [Category("Bubble Sorting Arrays")]
    public void GivenArray_BubbleSort_ReturnsExpectedResult(int[] input, int[] sortedArray)
    {
        Assert.That(BubbleSort.Sort(input), Is.EqualTo(sortedArray));
    }

    public static object[] AddCases2 =
    {
        new int[][] { new int[] { 5, 3 , 6, 4, 2 }, new int[] { 2,3,4,5,6 } },
        new int[][] { new int[] { -5, -3, -6, -4, -2 }, new int[] { -6,-5,-4,-3,-2 } },
        new int[][] { new int[] { -5, -3, 6, -4, 2 }, new int[] { -5,-4,-3,2,6 } }
    };
}
