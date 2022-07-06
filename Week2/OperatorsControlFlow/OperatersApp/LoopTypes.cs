using System;
namespace OperatersApp
{
    public class LoopTypes
    {
        public static int HighestForEachLoop(List<int> nums)
        {
            if (nums.Count == 0)
                throw new NullReferenceException("Empty List");

            int highest = nums[0];
            foreach (int i in nums)
                if (i > highest)
                    highest = i;
            return highest;
        }

        public static int HighestForLoop(List<int> nums)
        {
            if (nums.Count == 0)
                throw new NullReferenceException("Empty List");

            int highest = nums[0];
            for (int i = 0; i < nums.Count; i++)
                if (nums[i] > highest)
                    highest = nums[i];
            return highest;
                    
        }

        public static int HighestWhileLoop(List<int> nums)
        {
            if (nums.Count == 0)
                throw new NullReferenceException("Empty List");

            int highest = nums[0];
            int i = 0;
            while (i < nums.Count)
            {
                if (nums[i] > highest)
                    highest = nums[i];
                i++;
            }
            return highest;
        }

        public static int HighestDoWhileLoop(List<int> nums)
        {
            if (nums.Count == 0)
                throw new NullReferenceException("Empty List");

            int highest = nums[0];
            int i = 0;
            do
            {
                if (nums[i] > highest)
                    highest = nums[i];
                i++;
            } while (i < nums.Count);
            return highest;
        }

        // lowests
        public static int LowestForEachLoop(List<int> nums)
        {
            if (nums.Count == 0)
                throw new NullReferenceException("Empty List");

            int lowest = nums[0];
            foreach (int i in nums)
                if (i < lowest)
                    lowest = i;
            return lowest;
        }

        public static int LowestForLoop(List<int> nums)
        {
            if (nums.Count == 0)
                throw new NullReferenceException("Empty List");

            int lowest = nums[0];
            for (int i = 0; i < nums.Count; i++)
                if (nums[i] < lowest)
                    lowest = nums[i];
            return lowest;

        }

        public static int LowestWhileLoop(List<int> nums)
        {
            if (nums.Count == 0)
                throw new NullReferenceException("Empty List");

            int lowest = nums[0];
            int i = 0;
            while (i < nums.Count)
            {
                if (nums[i] < lowest)
                    lowest = nums[i];
                i++;
            }
            return lowest;
        }

        public static int LowestDoWhileLoop(List<int> nums)
        {
            if (nums.Count == 0)
                throw new NullReferenceException("Empty List");

            int lowest = nums[0];
            int i = 0;
            do
            {
                if (nums[i] < lowest)
                    lowest = nums[i];
                i++;
            } while (i < nums.Count);
            return lowest;
        }
    }
}

