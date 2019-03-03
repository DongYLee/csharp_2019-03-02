using System;
using System.Collections.Generic;
using System.Text;

namespace GenericArray
{
    class MyArray<T>
    {
        private T[] onj;
        public MyArray(int size) { onj = new T[size]; }
        public void SetElement(int index, T value)
        {
            onj[index] = value;
        }
        public T GetElement(int index, T value)
        {
            return onj[index];
        }

        public void PrintElements()
        {
            foreach (T o in onj) { Console.WriteLine(o); }
        }
    }

    class MainApp
    {
        public static void Main(string[] args)
        {
            MyArray<string> array = new MyArray<string>(4);

            array.SetElement(0, "OnjOracleJave");
            array.SetElement(1, "OracleJavaCommunity");
            array.SetElement(2, "onjprogmramming.co.kr");
            array.SetElement(3, "oraclehavanew.kr");
            array.PrintElements();

            string[] str_array = GetArray<string>(3, "오라클자바커뮤니티,오라클자바커뮤니티");
            foreach (string s in str_array) Console.WriteLine(s);
            int[] int_array = GetArray<int>(3, 999);
            foreach (int i in int_array) Console.WriteLine(i);
        }

        static T[] GetArray<T>(int size, T val)
        {
            T[] array = new T[size];
            for (int i = 0; i < size; i++) { array[i] = val; }
            return array;
        }        
    }
}