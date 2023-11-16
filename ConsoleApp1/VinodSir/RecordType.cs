using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VinodSir
{
    internal  class RecordType
    {
        public string name;
        public int age;

        public RecordType(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Name is {name} , Age is {age}");
        }

    }
}
