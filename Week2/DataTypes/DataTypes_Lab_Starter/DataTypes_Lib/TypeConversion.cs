using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            if (num > short.MaxValue)
                throw new OverflowException($"{num} cannot be converted to a short integer");
            return (short)num;
        }

        public static long FloatToLong(float num)
        {
            if (num == (long)num)
                return (long)num;
            else
                return (long)Math.Round((double)num, 0);
        }
    }
}
