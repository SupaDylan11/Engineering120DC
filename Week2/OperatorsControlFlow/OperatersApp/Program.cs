using System;

namespace OperatersApp;

public class Program
{
    public static void Main(string[] args)
    {
        int x = 0;
        int y = 0;
        // assign x then +1
        int a = x++;
        // assign +1 then y
        int b = ++y;

        LoopOperators();
        DivOperators();
        Console.WriteLine(WeeksAndDays(1345));

        List<int> nums = new List<int> {-22, 52, 6, 22, -17, 46, -19};

        Console.WriteLine("\n \nLOOPS HOMEWORK!");
        HighestLoops(nums);
        LowestLoops(nums);
    }


    public static void LoopOperators()
    {
        for (int i = 0; i < 10; ++i)
            Console.Write(i);
        Console.WriteLine("\n");

        for (int i = 0; i < 10; i++)
            Console.Write(i);
        Console.WriteLine("\n");

        Console.WriteLine("The loops function in the same way.");
    }

    public static void DivOperators()
    {
        var c = 5 / 2; // =2
        var d = 5.0 / 2; // =2.5
        var e = 5 / 3; // =1

        Console.WriteLine("5/2 = " + c + "\n5.0/2 = " + d + "\n5/3=" + e);
    }

    public static void ModuloOperator()
    {
        var g = 5 % 2; // = 1
        Console.WriteLine("5%2 = " + g);
    }

    public static string WeeksAndDays(int days)
    {
        var weeks = 0;
        var andDays = 0;

        weeks = days / 7;
        andDays = days % 7;

        return $"{weeks} weeks & {andDays} days!";
    }

    public static void HighestLoops(List<int> nums)
    {
        Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
        Console.WriteLine("Highest for- loop: " + LoopTypes.HighestForLoop(nums));
        Console.WriteLine("Highest while- loop: " + LoopTypes.HighestWhileLoop(nums));
        Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
    }

    public static void LowestLoops(List<int> nums)
    {
        Console.WriteLine("Lowest foreach loop: " + LoopTypes.LowestForEachLoop(nums));
        Console.WriteLine("Lowest for- loop: " + LoopTypes.LowestForLoop(nums));
        Console.WriteLine("Lowest while- loop: " + LoopTypes.LowestWhileLoop(nums));
        Console.WriteLine("Lowest do-while loop: " + LoopTypes.LowestDoWhileLoop(nums));
    }
}