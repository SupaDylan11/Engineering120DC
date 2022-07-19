using System;
using System.Text;

namespace FizzBuzz;

public class Program
{

    public static void Main(string[] hi)
    {

    }

    public static string FizzBuzz(int input)
    {
        if (input < 1)
            throw new ArgumentOutOfRangeException($"{input} is an invalid value. Please enter a value from 1 and up:- ");

        var result = new StringBuilder();
        for (int i = 1; i <= input; i++)
            if ((i % 3 == 0) && (i % 5 == 0))
                result.Append("FIZZBUZZ ");
            else if (i % 3 == 0)
                result.Append("FIZZ ");
            else if (i % 5 == 0)
                result.Append("BUZZ ");
            else
                result.Append(i + " ");
        return result.ToString();
    }
}
