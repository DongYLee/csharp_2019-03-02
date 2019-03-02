using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=2; i<=10; i+=2)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("\n");

            Console.WriteLine("숫자를 입력하세요");
            string str = Console.ReadLine();
            int num = 0, sum = 0;
            Int32.TryParse(str, out num);

            Console.WriteLine("입력숫자: {0}", num);
            Console.WriteLine("");
            Console.Write("{0}까지의 숫자: ", num);
            for (int i =1; i<=num; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.Write("\n");
            Console.WriteLine("{0}까지의 숫자합은: {1}", num, sum);

            Console.WriteLine("Input the 10 numbers :");
            Console.WriteLine("예: 1,2,3,4,5,6,7,8,9,10");
            str = Console.ReadLine();
            str.Trim();
            string[] strarr = str.Split(',');

            if (strarr.Length != 10)
            {
                Console.WriteLine("Input the 10 numbers :");
                Console.WriteLine("예: 1,2,3,4,5,6,7,8,9,10");
                return;
            }
            Int32[] tenNum = new Int32[10];
            sum = 0; 
            for(int i=0; i<=9; i++)
            {
                Int32.TryParse(strarr[i],out tenNum[i]);
                Console.WriteLine("숫자-{0} : {1}", i + 1, tenNum[i]);
                sum += tenNum[i];
            }
            Console.WriteLine("합 : {0}", sum);
            Console.WriteLine("평균 : {0}", (double)(sum / 10.0));


            Console.Write("출력을 원하는 구구단 단수 : ");
            str = Console.ReadLine();
            Int32.TryParse(str, out num);

            for(int i=1; i<=9; i++)
            {
                for (int j = 1; j < num; j++)
                {
                    Console.Write("{0}*{1}={2}, ", j, i, i * j);
                }
                Console.Write("{0}*{1}={2}\n", num, i, i * num);                
            }
        }
    }
}
