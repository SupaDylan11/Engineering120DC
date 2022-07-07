using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] contentArray = new string[contents.Count];
            for (int i = 0; i < contents.Count; i++)
                contentArray[i] = contents[i];

            return contentArray;
        }

        // returns a 3D array containing the contents of a given List
        // string[] oneDiArray = new string[contents.Count];
        // oneDiArray = contents.ToArray();
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            if (length1 * length2 * length3 != contents.Count)
                throw new ArgumentException("Number of elements in list must match array size");
            string[,,] threeDeeArray = new string[length1,length2,length3];
            int i = 0;
            for (int x = 0; x < length1; x++)
                for (int y = 0; y < length2; y++)
                    for (int z = 0; z < length3; z++)
                    {
                        threeDeeArray[x, y, z] = contents[i];
                        i++;
                    }

            return threeDeeArray;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            if (countRow1 + countRow2 != contents.Count)
                throw new ArgumentException("Number of elements in list must match array size");

            string[][] jaggedArray = new string[2][];
            jaggedArray[0] = new string[countRow1];
            jaggedArray[1] = new string[countRow2];
            int i = 0;

            for (int x = 0; x < countRow1; x++)
                jaggedArray[0][x] = contents[i++];

            for(int y = 0; y < countRow2; y++)
                jaggedArray[1][y] = contents[i++];
            return jaggedArray;
        }
    }
}
