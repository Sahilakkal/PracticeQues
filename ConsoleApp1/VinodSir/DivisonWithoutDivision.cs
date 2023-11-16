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
            static void Main()
            {

                double dividend = 10;
                double divisor = 3;


                double result = DivideWithoutDividee(dividend, divisor);

                Console.WriteLine($"Answ: {result}");
            }


            static double DivideWithoutDividee(double dividend, double divisor)
            {
                double result = 0;

                while (dividend >= divisor)
                {
                    dividend -= divisor;
                    result++;
                }


                double fraction = 0.1;

                for (int precision = 0; precision < 15; precision++)
                {
                    if (dividend >= divisor)
                    {
                        dividend -= divisor;
                        fraction *= 0.1;
                        result += fraction;
                    }
                }

                return result;
            }
        }

    }

