namespace FactorialApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int Factorial(int n)
        {
            if (n < 0) throw new ArgumentOutOfRangeException();
            else if (n == 1 || n == 0) return 1;
            else
            {
                return n*Factorial(n-1);
            }
        }
    }
}