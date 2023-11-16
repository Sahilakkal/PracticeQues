using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VinodSir
{
    internal class ChangeSeqOfParameters
    {
        public static int Add(int firstNum, int secondNum)
        {
            xa(firstNum);
            void xa(int x)
            {
                Console.WriteLine(x);

            }
            return firstNum - secondNum;
        }
    }
}
