using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
class SumTest
{
    static void Main()
    {
        Console.WriteLine(Sum(1, 2));
        Console.WriteLine(Sum(1, 2, 3));
        Console.WriteLine(Sum(new int[] { 1, 2, 3, 4, 5 }));

    }
    //static int Sum(int i, int j)   {        return i + j;    }
    //static int Sum(int i, int j, int k ) { return i + j + k; }
    static int Sum(params int[] iArr)
    {
        int s = 0;
        foreach (int num in iArr) s += num;
        return s;
    }
}

class Tester
{
        static void Main()
        {
                Console.WriteLine(Sum(j: 1, i: 2));
                SayHello(age: 20, name: "OJC");
        }

        static int Sum(int i, int j)
        {
            Console.WriteLine("i={0}, j={1}", i, j);
            return i + j;
        }

        static void SayHello(string name, int age)
        {
            Console.WriteLine("안녕, name = {0}, age = {1}", name, age);
        }
}
*/

class Tester
{
    private int m = 88, n = 99;

    Tester(int m = 0, int n = 0)
    {
        this.m = m; this.n = n;
    }

    static int Sum(int i = 0, int j = 0)
    {
        return i + j;
    }

    static void Main()
    {
        Console.WriteLine(Sum(1, 2));
        Console.WriteLine(Sum(j: 7));
        Console.WriteLine(Sum());

        Tester t1 = new Tester();
        Console.WriteLine("m={0}, n={1}", t1.m, t1.n);

        Tester t2 = new Tester(1, 2);
        Console.WriteLine("m={0}, n={1}", t2.m, t2.n);
    }
}

