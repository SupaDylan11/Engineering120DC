using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            if (num > queue.Count)
                num = queue.Count;

            var result = "";
            for (int i = 0; i < num; i++)
                if (i == 0)
                    result = $"{queue.Dequeue()}";
                else
                    result = $"{result}, {queue.Dequeue()}";
            return result;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            if (original.Length == 0)
                return Array.Empty<int>();

            var result = new int[original.Length];
            var stack = new Stack<int>();

            foreach (int i in original)
                stack.Push(i);

            for (int i = 0; i < result.Length; i++)
                result[i] = stack.Pop();

            return result;
        }

        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            if (input == "")
                return "";

            var numberDict = new Dictionary<char, int>();

            foreach (char i in input)
                if (Int32.TryParse(i.ToString(), out int result))
                {
                    if (numberDict.ContainsKey(i))
                        numberDict[i]++;
                    else
                        numberDict.Add(i, 1);
                }

            string resultStr = "";
            foreach (KeyValuePair<char, int> x in numberDict)
                resultStr = $"{resultStr}[{x.Key}, {x.Value}]";

            return resultStr;
        }
    }
}

/*
             // Dictionaries
            var personDict = new Dictionary<string, Person>
            {
                { "helen", helen},
                {"tom", new Person("Thomas") }
            };

            var p = personDict["tom"];
            var successAddPerson = personDict.TryAdd("helen", new Person("Tester"));

            personDict.Add("bill", will);

            string input = "The cat in the hat comes back";
            input = input.Trim().ToLower();
            var countDict = new Dictionary<char, int>();

            foreach(char c in input)
            {
                if(countDict.ContainsKey(c))
                {
                    countDict[c]++;
                } else
                {
                    countDict.Add(c, 1);
                }
            }*/