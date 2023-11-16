using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VinodSir
{
    public class PrecedenceOp : c
    {
        void a()
        {
            Console.WriteLine("Hello");
            
        }

        void c.a()
        {
            throw new NotImplementedException();
        }
    }

    public interface c
    {
         void a();
    }
}
