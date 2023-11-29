using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.VinodSir
{
    internal class StringConstructorr
    {
        public static void funcStringIntern()
        {
            string s1 = "sahil";
            string s = new StringBuilder().Append("sahil").ToString();
            string s2 = String.Intern(s1);
            string s3 = "sahil";

            unsafe
            {
                Console.WriteLine(String.IsInterned(s));
                Console.WriteLine(s1 == s3);
                Console.WriteLine(s1.Equals(s));
                Console.WriteLine(s1 == s2);
                Console.WriteLine((long)&s1);
                Console.WriteLine((long)&s2);
                Console.WriteLine((long)&s3);


            }
        }
    }
}
