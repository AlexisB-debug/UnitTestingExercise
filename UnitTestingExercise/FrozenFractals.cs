using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExercise;

public static class FrozenFractals
{
    public static decimal FrozenDecimal(int dividend, int divisor)
    {
        if (dividend == 0)
        {
            return 0;
        }
        else if (divisor == 0)
        {
            throw new Exception();
        }
        else
        {
            StringBuilder place = new StringBuilder();
            place.Append(Math.Abs(dividend) / Math.Abs(divisor));
            dividend = Math.Abs(dividend) % Math.Abs(divisor);

            if (dividend == 0)
            {
                return decimal.Parse(place.ToString());
            }
            else
            {
                place.Append(".");
                Dictionary<int, int> remainderMap = new Dictionary<int, int>();

                while (Math.Abs(dividend) != 0 && !remainderMap.ContainsKey(dividend))
                {
                    remainderMap.Add(Math.Abs(dividend), place.Length);
                    dividend = Math.Abs(dividend) * 10;
                    place.Append(Math.Abs(dividend) / Math.Abs(divisor));
                    dividend = Math.Abs(dividend) % Math.Abs(divisor);
                }

                return decimal.Parse(place.ToString());
            }
        }
    }
}