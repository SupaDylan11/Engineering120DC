using System;

namespace WeightApp;

public class Methods
{
    public static void Main(string[] args)
    {
        bool running = true;
        int pounds;
        while (running)
        {
            Console.WriteLine("Enter the number of pounds! ");
            var a = Console.ReadLine();
            pounds = Convert.ToInt32(a);
            Console.WriteLine("This is " + GetStones(pounds)
                + " stones and " + GetPounds(pounds) + " pounds");

            Console.WriteLine("Do you wish to continue? (Y for yes, N for No)");
            string input = Console.ReadLine();
            if (string.Equals(input, "y", StringComparison.OrdinalIgnoreCase))
                running = true;
            else
                running = false;
        }
    }

    public static int GetStones(int pounds)
    {
        if (pounds <= 0)
            return 0;
        else
            return pounds / 14;
    }

    public static int GetPounds(int pounds)
    {
        if(pounds <= 0)
            return 0;
        else
            return pounds % 14;
    }
}