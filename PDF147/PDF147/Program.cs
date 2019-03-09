using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF147
{
    class Program
    {
        //    private delegate int OnjSum(int i, int j);
        static void Main(string[] args)
        {
            //Program d = new Program();
            //OnjSum myMethod = new OnjSum(Program.Sum);
            //OnjSum myMethod = new OnjSum(Sum); //2. 생성
            //Func<int, int, int> myMethod = Sum; 
            Action<int, int> myMethod = Sum;
            myMethod(10, 30);
            //Console.WriteLine("두수 합 : {0}", myMethod(10, 30));

            Action myHello = SayHelloKr;
            SayHello(myHello);
            myHello = SayHelloEn;
            SayHello(myHello);
        }

        static void SayHello(Action hello) { hello(); }
        static void SayHelloKr()
        {
            Console.WriteLine("안녕");
        }
        static void SayHelloEn()
        {
            Console.WriteLine("Hello");
        }
        static void Sum(int i, int j)
        {
            //return i + j;
            Console.WriteLine(i + j);
        }

    }
}