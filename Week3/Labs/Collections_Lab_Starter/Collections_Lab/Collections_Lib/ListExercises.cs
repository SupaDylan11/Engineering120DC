using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises : IEnumerable
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            List<int> list = new() { };
            for (int i = 1; i <= max; i++)
                if (i % 5 == 0)
                    list.Add(i);
            return list;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            List<string> resultList = new() { };
            for (int i = 0; i < sourceList.Count; i++)
                //if (sourceList[i].Substring(0, 1).Equals("a") )
                if (string.Equals(sourceList[i][..1], "a", StringComparison.OrdinalIgnoreCase))
                    resultList.Add(sourceList[i]);
            return resultList;
        }

        public static List<int> MakeFiveOneLine(int maks)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
