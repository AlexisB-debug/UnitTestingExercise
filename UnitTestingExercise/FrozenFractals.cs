using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingExercise;

public static class FrozenFractals
{
    public static decimal FrozenDecimal(int dividend, int divisor)
    {
        try
        {
            if (dividend == 0)
            {
                return 0;
            }
            else
            {
                StringBuilder decimalForm = new StringBuilder();

                if ((dividend < 0) ^ (divisor < 0))
                {
                    decimalForm.Append('-');
                }

                decimalForm.Append(Math.Abs(dividend) / Math.Abs(divisor));
                dividend = Math.Abs(dividend) % Math.Abs(divisor);

                if (dividend == 0)
                {
                    return decimal.Parse(decimalForm.ToString());
                }
                else
                {
                    decimalForm.Append('.');
                    Dictionary<int, int> remainderMap = new Dictionary<int, int>();

                    while (Math.Abs(dividend) != 0 && !remainderMap.ContainsKey(dividend))
                    {
                        remainderMap.Add(Math.Abs(dividend), decimalForm.Length);
                        dividend = Math.Abs(dividend) * 10;
                        decimalForm.Append(Math.Abs(dividend) / Math.Abs(divisor));
                        dividend = Math.Abs(dividend) % Math.Abs(divisor);
                    }

                    return decimal.Parse(decimalForm.ToString());
                }
            }
        }
        catch (DivideByZeroException)
        {
            throw new DivideByZeroException();
        }
    }
}