using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요.");
            string str = Console.ReadLine();
            int m = 0;
            bool parsed = Int32.TryParse(str, out m);

            if (!parsed)
            {

            }

            int i = 0, sum = 0;
            while (i <= m)
            {
                if (i % 2 == 0) sum += i;
                i++;
            }
            Console.WriteLine("1부터 {0}까지의 짝수합 {1}", m, sum);

            i = 0;            sum = 0;
            do
            {
                if (i % 2 == 0) sum += i;
                i++;
            } while (i <= m);
            Console.WriteLine("1부터 {0}까지의 짝수합 {1}", m, sum);

            sum = 0;
            for (i = 0; i <= m; i++)
            {
                if (i % 2 == 0) sum += i;
                i++;
            }
            Console.WriteLine("1부터 {0}까지의 짝수합 {1}", m, sum);
        }
    }
}
