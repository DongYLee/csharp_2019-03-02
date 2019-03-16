using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF187
{
    class Program
    {
        
        static bool isEven(int num)
        {
            return num % 2 == 0;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, };

            //IEnumerable<int> q1 = numbers.Where(num => num % 2 == 0).OrderByDescending(n => n);            
            //IEnumerable<int> q1 = numbers.Where(n => n % 2 == 0).OrderByDescending(n => n);
            IEnumerable<int> q1 = numbers.Where(new Func<int, bool>(isEven)).OrderByDescending(n => n);
            //IEnumerable<int> q1 = numbers.Where(isEven).OrderByDescending(n => n);

            foreach (int i in q1) Console.Write(i + " ");

            Console.WriteLine();

            int sum = numbers.Where(num => num % 2 == 0).Sum();
            Console.WriteLine("Sum = " + sum);

            int max = numbers.Where(num => num % 2 == 0).Max();
            Console.WriteLine("Max = " + max);

            double avg = numbers.Where(num => num % 2 == 0).Average();
            Console.WriteLine("Avg = " + avg);

            var result = numbers.Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregation = " + result);

            result = numbers.Aggregate(10, (a, b) => a + b);
            Console.WriteLine("Aggregation with seed =" + result);

            result = numbers.Where(num => num % 2 == 0).Aggregate((a, b) => a * b);
            Console.WriteLine("Aggregarion.Where = " + result);

            Console.WriteLine("\n--------------");
        }
    }
}