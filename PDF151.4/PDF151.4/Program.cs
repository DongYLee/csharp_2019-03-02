using System;
using System.Collections.Generic;
using System.Text;

namespace deledatetest
{
    delegate void OnjDelegate(int a, int b);
    class MainApp
    {
        static void Plus(int a, int b)
        { Console.WriteLine("{0} + {1} = {2}", a, b, a + b); }
        static void Minus(int a, int b)
        { Console.WriteLine("{0} - {1} = {2}", a, b, a - b); }
        void Multiplication(int a, int b)
        { Console.WriteLine("{0} * {1} = {2}", a, b, a * b); }
        static void Division(int a, int b)
        { Console.WriteLine("{0} / {1} = {2}", a, b, a / b); }

        static void Main()
        {
            MainApp m = new MainApp();
            /*OnjDelegate CallBack = (OnjDelegate)Delegate.Combine(
                new OnjDelegate(MainApp.Plus),
                new OnjDelegate(MainApp.Minus),
                new OnjDelegate(m.Multiplication),
                new OnjDelegate(m.Division));*/

            /*OnjDelegate CallBack = new OnjDelegate(MainApp.Plus);
            CallBack += new OnjDelegate(MainApp.Minus);
            CallBack += new OnjDelegate(m.Multiplication);
            CallBack += new OnjDelegate(m.Division); */

            OnjDelegate CallBack = MainApp.Plus;
            CallBack += MainApp.Minus;
            CallBack += m.Multiplication;
            CallBack += Division;
            CallBack(4, 3);
        }
    }
}