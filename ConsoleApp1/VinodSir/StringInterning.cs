using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VinodSir
{
    internal class StringInterning
    {
        public static void StringInterningg()
        {
            string s = "Hell" + "o";
            StringBuilder sb = new StringBuilder();

            string str = "HELLO";
            string str1 = (new StringBuilder().Append("HE").Append("ih").ToString());

            string str2 = (new StringBuilder().Append("HELLO0").ToString());
            string x = String.Intern(str1);
            Console.WriteLine(String.IsInterned(""));

            //jab mene append me kuch pass kra to isne tabhi bna dia ek literal or vo intern pool me store hogeya
        }
    }
}
