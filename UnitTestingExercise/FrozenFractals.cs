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
                int keyRemainder = Math.Abs(dividend) % Math.Abs(divisor);

                if (keyRemainder == 0)
                {
                    return decimal.Parse(decimalForm.ToString());
                }
                else
                {
                    decimalForm.Append('.');

                    // The first code I created

                    int? nextRemainder = null;

                    while (nextRemainder != 0 && nextRemainder != keyRemainder)
                    {
                        if (nextRemainder == null)
                        {
                            nextRemainder = keyRemainder;
                        }

                        nextRemainder = nextRemainder * 10;
                        decimalForm.Append(nextRemainder / Math.Abs(divisor));
                        nextRemainder = nextRemainder % Math.Abs(divisor);
                    }

                    // The second code I created, which performs as well, is to exploit a do-while loop's exit-control property to guarantee an iteration.
                    //
                    // int nextRemainder = keyRemainder;
                    //
                    // do
                    // {
                    //     nextRemainder = nextRemainder * 10;
                    //     decimalForm.Append(nextRemainder / Math.Abs(divisor));
                    //     nextRemainder = nextRemainder % Math.Abs(divisor);
                    // } while (nextRemainder != 0 && nextRemainder != keyRemainder);

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