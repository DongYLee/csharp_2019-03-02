using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class AddClass
    {
        public int val { get; set; }
        public static AddClass operator +(AddClass op1, AddClass op2)
        {
            AddClass a = new AddClass();
            a.val = op1.val + op2.val;
            return a;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AddClass a1 = new AddClass(); a1.val = 1;
            AddClass a2 = new AddClass(); a2.val = 2;
            
           // AddClass a3 = a1 + a2;
            AddClass a4 = new AddClass();
            a4 = a1 + a2; 
            Console.WriteLine(a4.val);

            int a = 1, b = 3;
            int c = a + b;

        }
    }
}
