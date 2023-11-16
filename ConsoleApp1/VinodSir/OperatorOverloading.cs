using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VinodSir
{
    internal class OperatorOverloading
    {
        public int num1, num2;

        public OperatorOverloading(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;

            
        }

        public static int operator +(OperatorOverloading obj1,OperatorOverloading obj2) //contanining type must be there atleast one for operator overlaoading
        {
            return obj1.num1 - obj2.num2;

        }

        public void Print(OperatorOverloading obj1)
        {
            Console.WriteLine(obj1);
        }

    }
}
