using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    class Rtype
    {
        public object Value;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = a;
            Console.WriteLine(a);
            Console.WriteLine(b);

            b = 2;
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine("----------------------------");

            Rtype c = new Rtype();
            Rtype d = new Rtype();

            c.Value = 1; d = c;
            Console.WriteLine(c.Value); Console.WriteLine(d.Value);

            d.Value = 2;
            Console.WriteLine(c.Value); Console.WriteLine(d.Value);
        }
    }
}
