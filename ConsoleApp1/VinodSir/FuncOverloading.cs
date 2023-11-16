using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VinodSir
{
    internal class FuncOverloading
    {
        public static void func1(ref int num)
        {
            Console.WriteLine("i am ref func1");
        }

        public static void func1(int z)
        {
            Console.WriteLine("I am func1 ultra pro max");

        }
        unsafe  //without it we can declare this varible
        public static void func2(int* z)
        {
            Console.WriteLine("i am pointer func2");
        }


    }
}

