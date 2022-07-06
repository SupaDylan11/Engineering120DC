using OperatersApp;

namespace LoopsTest;

public class UnitTest1
{
    // testing the foreach loop
    [Test]
    public void TestingForEachLoop_WithFirstValueBeingHighest_ReturnFirstValue()
    {
        List<int> nums = new List<int> { 10, 6, 3, -17, 5 };
        Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(10));
    }

    [Test]
    public void TestingForEachLoop_ReturnHighestValue()
    {
        List<int> nums = new List<int> { 10, 16, 29, 10, 20 };
        Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(29));
    }

    [Test]
    public void TestingForEachLoop_WithLastValueBeingHighest_ReturnLastValue()
    {
        List<int> nums = new List<int> { 10, 16, 16, 10, 20 };
        Assert.That(LoopTypes.HighestForEachLoop(nums), Is.EqualTo(20));
    }

    // testing the for loop
    [Test]
    public void TestingForLoop_WithFirstValueBeingHighest_ReturnFirstValue()
    {
        List<int> nums = new List<int> { 10, 6, 3, -17, 5 };
        Assert.That(LoopTypes.HighestForLoop(nums), Is.EqualTo(10));
    }

    [Test]
    public void TestingForLoop_ReturnHighestValue()
    {
        List<int> nums = new List<int> { 10, 16, 29, 10, 20 };
        Assert.That(LoopTypes.HighestForLoop(nums), Is.EqualTo(29));
    }

    [Test]
    public void TestingForLoop_WithLastValueBeingHighest_ReturnLastValue()
    {
        List<int> nums = new List<int> { 10, 16, 16, 10, 20 };
        Assert.That(LoopTypes.HighestForLoop(nums), Is.EqualTo(20));
    }

    // testing the while
    [Test]
    public void TestingWhileLoop_WithFirstValueBeingHighest_ReturnFirstValue()
    {
        List<int> nums = new List<int> { 10, 6, 3, -17, 5 };
        Assert.That(LoopTypes.HighestWhileLoop(nums), Is.EqualTo(10));
    }

    [Test]
    public void TestingWhileLoop_ReturnHighestValue()
    {
        List<int> nums = new List<int> { 10, 16, 29, 10, 20 };
        Assert.That(LoopTypes.HighestWhileLoop(nums), Is.EqualTo(29));
    }

    [Test]
    public void TestingWhileLoop_WithLastValueBeingHighest_ReturnLastValue()
    {
        List<int> nums = new List<int> { 10, 16, 16, 10, 20 };
        Assert.That(LoopTypes.HighestWhileLoop(nums), Is.EqualTo(20));
    }

    // testing the dowhile
    [Test]
    public void TestingDoWhileLoop_WithFirstValueBeingHighest_ReturnFirstValue()
    {
        List<int> nums = new List<int> { 10, 6, 3, -17, 5 };
        Assert.That(LoopTypes.HighestDoWhileLoop(nums), Is.EqualTo(10));
    }

    [Test]
    public void TestingDoWhileLoop_ReturnHighestValue()
    {
        List<int> nums = new List<int> { 10, 16, 29, 10, 20 };
        Assert.That(LoopTypes.HighestDoWhileLoop(nums), Is.EqualTo(29));
    }

    [Test]
    public void TestingDoWhileLoop_WithLastValueBeingHighest_ReturnLastValue()
    {
        List<int> nums = new List<int> { 10, 16, 16, 10, 20 };
        Assert.That(LoopTypes.HighestDoWhileLoop(nums), Is.EqualTo(20));
    }








    //lowest values
    // testing the foreach loop
    [Test]
    public void TestingForEachLoop_WithFirstValueBeingLowest_ReturnFirstValue()
    {
        List<int> nums = new List<int> {2, 6, 3, 10, 5 };
        Assert.That(LoopTypes.LowestForEachLoop(nums), Is.EqualTo(2));
    }

    [Test]
    public void TestingForEachLoop_ReturnLowestValue()
    {
        List<int> nums = new List<int> { 10, 16, 29, 6, 20 };
        Assert.That(LoopTypes.LowestForEachLoop(nums), Is.EqualTo(6));
    }

    [Test]
    public void TestingForEachLoop_WithLastValueBeingLowest_ReturnLastValue()
    {
        List<int> nums = new List<int> { 10, 16, 16, 10, 3 };
        Assert.That(LoopTypes.LowestForEachLoop(nums), Is.EqualTo(3));
    }

    // testing the for loop
    [Test]
    public void TestingForLoop_WithFirstValueBeingLowest_ReturnFirstValue()
    {
        List<int> nums = new List<int> { 2, 6, 3, 10, 5 };
        Assert.That(LoopTypes.LowestForLoop(nums), Is.EqualTo(2));
    }

    [Test]
    public void TestingForLoop_ReturnLowestValue()
    {
        List<int> nums = new List<int> { 10, 16, 29, 6, 20 };
        Assert.That(LoopTypes.LowestForLoop(nums), Is.EqualTo(6));
    }

    [Test]
    public void TestingForLoop_WithLastValueBeingLowest_ReturnLastValue()
    {
        List<int> nums = new List<int> { 10, 16, 16, 10, 3 };
        Assert.That(LoopTypes.LowestForLoop(nums), Is.EqualTo(3));
    }

    // testing the while
    [Test]
    public void TestingWhileLoop_WithFirstValueBeingLowest_ReturnFirstValue()
    {
        List<int> nums = new List<int> {2, 6, 3, 10, 5 };
        Assert.That(LoopTypes.LowestWhileLoop(nums), Is.EqualTo(2));
    }

    [Test]
    public void TestingWhileLoop_ReturnLowestValue()
    {
        List<int> nums = new List<int> { 10, 16, 29, 6, 20 };
        Assert.That(LoopTypes.LowestWhileLoop(nums), Is.EqualTo(6));
    }

    [Test]
    public void TestingWhileLoop_WithLastValueBeingLowest_ReturnLastValue()
    {
        List<int> nums = new List<int> { 10, 16, 16, 10, 3 };
        Assert.That(LoopTypes.LowestWhileLoop(nums), Is.EqualTo(3));
    }

    // testing the dowhile
    [Test]
    public void TestingDoWhileLoop_WithFirstValueBeingLowest_ReturnFirstValue()
    {
        List<int> nums = new List<int> { 2, 6, 3, 10, 5 };
        Assert.That(LoopTypes.LowestDoWhileLoop(nums), Is.EqualTo(2));
    }

    [Test]
    public void TestingDoWhileLoop_ReturnLowestValue()
    {
        List<int> nums = new List<int> { 10, 16, 29, 6, 20 };
        Assert.That(LoopTypes.LowestDoWhileLoop(nums), Is.EqualTo(6));
    }

    [Test]
    public void TestingDoWhileLoop_WithLastValueBeingHighest_ReturnLowestValue()
    {
        List<int> nums = new List<int> { 10, 16, 16, 10, 3 };
        Assert.That(LoopTypes.LowestDoWhileLoop(nums), Is.EqualTo(3));
    }
}


