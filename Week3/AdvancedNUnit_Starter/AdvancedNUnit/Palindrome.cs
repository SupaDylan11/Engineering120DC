using System;
using System.Collections.Generic;

namespace AdvancedNUnit
{
    public class Palindrome
    {
        public static bool IsItPalendrome(string input)
        {
            if (input == "")
                throw new ArgumentException("An empty string cannot be a palindrome");

            input = input.Replace(" ", String.Empty);
            var inputStack = new Stack<char>();

            foreach (char i in input)
                inputStack.Push(i);

            string resultString = "";

            for (int i = 0; i < input.Length; i++)
                resultString += inputStack.Pop();

            return string.Equals(input, resultString, StringComparison.OrdinalIgnoreCase);
        }
    }
}
