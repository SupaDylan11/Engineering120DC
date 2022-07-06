using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        //Assert.That(() => IntegerCalc.Add(int.MaxValue, 3), Throws.TypeOf<OverflowException>());
        public static int Add(int num1, int num2)
        {
            if ((long)num1 + (long)num2 > int.MaxValue)
                throw new OverflowException("Numbers are too large");
            else if ((long)num1 + (long)num2 < int.MinValue)
                throw new OverflowException("Numbers are too negatively large");
            else
                return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            if ((long)num1 - (long)num2 < int.MinValue)
                throw new OverflowException("Operands are too large");
            else if ((long)num1 - (long)num2 > int.MaxValue)
                throw new OverflowException("Operands are too negatively large");
            else
                return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 == 0)
                throw new ArgumentException("Can't divide by zero");
            else
                return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            if (num2 == 0)
                throw new ArgumentException("Can't modulo by zero");
            else
                return num1 % num2;
        }
    }
}
