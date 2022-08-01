namespace LambdaExpressions
{
    /*
     * Lambders:
     *  Have no name,
     *  Is declared at the place it is used
     *  cannot be reused anywhere else
     *  The type of parameters are inferred from context.
     */
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 3, 7, 1, 2, 8, 3, 0, 4, 5};

            int allCountAlt = 0;
            foreach (var num in nums)
                allCountAlt++;

            int countEven = 0;
            foreach (var num in nums)
                if (IsEven(num))
                    countEven++;

            int allCount = nums.Count(IsEven); // returns same result as the foreach loop

            int countDEven = nums.Count(delegate (int x) { return x % 2 == 0; });
            int coundLEven = nums.Count(x => x % 2 == 0);

            //using a lambda expression, in one line
            //find the total age of people at lease 30 years old
            var people = new List<Person>
            {
                new Person("Nish", "Norwich", 35),
                new Person("Rolf", "Norwich", 75),
                new Person("Mario", "Norwich", 15)
            };

        }

        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }
}