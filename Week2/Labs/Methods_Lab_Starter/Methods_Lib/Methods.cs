using System;

namespace Methods_Lib
{
    public class Methods
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(RollDice(new Random()));
        }

        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0)
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            else
                return (totalDays / 7, totalDays % 7);
        }

        public static (int square, int cube, double sqrRoot) PowersRoot (int number)
        {
            if (number < 0)
                throw new ArgumentOutOfRangeException("Square number must not be negative");
            else
                return ((int) Math.Pow(number, 2), (int) Math.Pow(number, 3), Math.Sqrt(number));
        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }
        
    }
}
