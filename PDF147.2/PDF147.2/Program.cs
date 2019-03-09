using System;

delegate int SumDeli(int i, int j);
class DeliTest
{
    static void Main()
    {
        SumDeli s1 = DeliTest.Sum1;
        SumDeli s2 = new SumDeli(DeliTest.Sum2);
        S(s1); S(s2);
    }

    static void S(SumDeli s) { Console.WriteLine(s(1, 2)); }
    static int Sum1(int i, int j) { return i + j; }
    static int Sum2(int i, int j) { return i + j + 100; }
}