using System;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            input = input.Trim().ToUpper();
            for (int i = 0; i < num; i++)
                input = input + i.ToString();
            return input;
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return number + " " + street + ", " + city + " " + postcode + ".";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double result = ((double)score / (double)outOf * 100.0);
            double percentage = Math.Round(result, 1);
            return $"You got {score} out of {outOf}: {percentage}%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            double stringNumber;
            if (Double.TryParse(numString, out stringNumber))
                return stringNumber;
            else
                return -999;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        // A:0 B:0 C:0 D:0
        public static string CountLetters(string input)
        {
            char[] inputArray = input.ToCharArray();
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;

            foreach(char i in inputArray)
            {
                if (i.Equals('A'))
                    aCount++;
                else if (i.Equals('B'))
                    bCount++;
                else if (i.Equals('C'))
                    cCount++;
                else if (i.Equals('D'))
                    dCount++;
            }

            return $"A:{aCount} B:{bCount} C:{cCount} D:{dCount}";
        }
    }
}
