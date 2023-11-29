using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VinodSir
{
    internal class DivisonWithoutDivision
    {

        class Program
        {
            static void Main111()
            {
                int dividend = 13;
                int divisor = 3;

                int quotient = RestoringDivision(dividend, divisor);
                Console.WriteLine($"Quotient: {quotient}");
            }

            static int RestoringDivision(int dividend, int divisor)
            {
                if (divisor == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }

                bool isNegative = (dividend < 0) ^ (divisor < 0);
                dividend = Math.Abs(dividend);
                divisor = Math.Abs(divisor);

                int quotient = 0;
                int remainder = 0;

                for (int i = 31; i >= 0; i--)
                {
                    remainder <<= 1; // Left shift remainder
                    remainder |= ((dividend >> i) & 1); // Extract bit from dividend to remainder

                    if (remainder >= divisor)
                    {
                        remainder -= divisor;
                        quotient |= (1 << i); // Set bit in quotient
                    }
                }

                return isNegative ? -quotient : quotient;
            }
        }


    }
}
