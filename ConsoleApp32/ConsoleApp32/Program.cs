using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Adder1
    {
        public int Val { get; set; }
        public static Adder3 operator+(Adder1 op1, Adder2 op2)
        {
            Adder3 a = new Adder3();
            a.Val = op1.Val + op2.Val;
            return a;
        }
    }
    class Adder2
    {
        public int Val { get; set; }
    }
    class Adder3
    {
        public int Val { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adder1 a1 = new Adder1(); 
            Adder2 a2 = new Adder2();
            Adder3 a3 = a1 + a2;
            a3 = a1 + a2; 
        }
    }
}
