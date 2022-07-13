using System;

namespace MethodsApp;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(DoThis(10, "Desent"));
    }

    public static string DoThis(int x, string y)
    {
        int result = x * x;
        return $"I'm feeling {y}. Oh, by the way, {x} squared is {result}";
    }
}

