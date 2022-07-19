namespace SortingAlgos;



public class BubbleSort
{
    public static int[] Sort(int [] intArray)
    {

        int temp;
        for (int j = 0; j < intArray.Length - 1; j++)
        {
            for (int i = 0; i < intArray.Length - 1; i++)
            {
                if (intArray[i] > intArray[i + 1])
                {
                    temp = intArray[i]; // hold the larger vakue in the temp holder
                    intArray[i] = intArray[i + 1]; // make intArray[i] be equal to smaller value
                    intArray[i + 1] = temp; // place the temp value into the intArray[i + 1]
                }
            }
        }
        return intArray ;
    }
}

