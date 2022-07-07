using System;
namespace MoreDataTypesApp;

public class Program
{
    public static void Main(string[] args)
    {
        string message = "All Cops Are Blighters. "; // i dont fancy swearing. i am Christian
        Console.WriteLine(message);
        message = message.Insert(message.Length, "Black Lives Matter! ");
        Console.WriteLine(message);
        message = message.Insert(message.Length, "\nI don't fancy swearing though, I am Christian! ");
        Console.WriteLine(message);

        Console.WriteLine(StringExercise("    Jesus Christ is my God & King    "));

        Console.WriteLine("The a + b: " + StringInterpolation("a", "b"));
        Console.WriteLine("The String.Concat(a, b): " + StringConcat("a", "b"));
    }

    public static string StringInterpolation(string a, string b)
    {
        return a + b;
    }

    public static string StringConcat(string a, string b)
    {
        return String.Concat(a, b);
    }

    public static string StringExercise(string myString)
    {
        string text = myString.Trim();
        text = text.ToUpper();
        text = text.Remove(text.IndexOf('N') + 1);
        char[] charArray = text.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i].Equals('L') || charArray[i].Equals('L'))
                charArray[i] = '*';
        }

        string result = new string(charArray);
        return result;
    }
}