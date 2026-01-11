using System;
using System.Text;

namespace UnitTestingExercise;

public static class FrozenFractals
{
    public static decimal FrozenDecimal(int dividend, int divisor)
    {
        try
        {
            StringBuilder decimalForm = new StringBuilder();

            if ((dividend < 0) ^ (divisor < 0))
            {
                decimalForm.Append('-');
            }

            decimalForm.Append(Math.Abs(dividend) / Math.Abs(divisor));
            int keyRemainder = Math.Abs(dividend) % Math.Abs(divisor);
            decimalForm.Append('.');

            // The first loop I created:

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

            // The second loop I created, which performs perfect, is to exploit a do-while loop's exit-control property
            // to guarantee an iteration.
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
        catch (DivideByZeroException)
        {
            throw new DivideByZeroException();
        }
    }
}
