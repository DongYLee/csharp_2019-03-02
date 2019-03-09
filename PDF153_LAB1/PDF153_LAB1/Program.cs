using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF153_LAB1
{
    delegate void Calc(int a, int b);

    class Program
    {
        static void Plus(int a, int b) { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
        static void Minus(int a, int b) { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
        static void Multiplication(int a, int b) { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
        static void Division(int a, int b) { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }

        static void Main(string[] args)
        {
            Console.WriteLine("input two integer number(ex. 1,2):");
            string str = Console.ReadLine();            
            str.Trim();
            string[] strarr = str.Split(',');

            int a = int.Parse(strarr[0]); int b = int.Parse(strarr[1]);

            Calc CallBack = Plus;
            CallBack += Minus;
            CallBack += Multiplication;
            CallBack += Division;

            CallBack(a, b);

            Calc CallBack2 = (Calc)Delegate.Combine(
                new Calc(Plus), new Calc(Minus),new Calc(Multiplication), 
                new Calc(Division));

            CallBack2(a, b);
        }
    }
}
