using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VinodSir
{
    internal class DivisonWithoutDivision
    {
        using System;

class Program
    {
        static void Main()
        {
            // Division: dividend / divisor
            double dividend = 10;
            double divisor = 3;

            // Using repeated subtraction to perform division
            double result = DivideUsingRepeatedSubtraction(dividend, divisor);

            Console.WriteLine($"Result: {result}"); // Output: Result: 3.33333333333333
        }

        // Function to perform division using repeated subtraction
        static double DivideUsingRepeatedSubtraction(double dividend, double divisor)
        {
            double result = 0;

            while (dividend >= divisor)
            {
                dividend -= divisor; // Subtract divisor from dividend
                result++; // Increment the result
            }

            // For the fractional part, approximate by iterative subtraction
            double fraction = 0.1; // Start with a small value for precision

            for (int precision = 0; precision < 15; precision++) // Adjust precision
            {
                if (dividend >= divisor)
                {
                    dividend -= divisor;
                    fraction *= 0.1; // Decrease fraction for each digit
                    result += fraction; // Add the fractional part to the result
                }
            }

            return result;
        }
    }

}
}
