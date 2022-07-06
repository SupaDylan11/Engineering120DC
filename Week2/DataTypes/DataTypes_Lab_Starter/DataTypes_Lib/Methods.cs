using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static long Factorial(int n)
        {
            long result = 1;

            if (n < 1)
                throw new ArgumentOutOfRangeException($"{n} is invalid. Please enter a number that is at least 1.");
            else
                for (int i = 1; i <= n; i++)
                    result *= i;

            return result;
        }

        public static float Mult(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}
