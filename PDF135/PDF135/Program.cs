using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF135
{
    class DataStore<T>
    {
        private T[] s = new T[10];
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= s.Length)
                    throw new IndexOutOfRangeException("cannot store more than 10 ojects");
                return s[index];
            }
            set
            {
                if (index < 0 || index >= s.Length)
                    throw new IndexOutOfRangeException("cannot store more than 10 ojects");
                s[index] = value;
            }
        }
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> ds1 = new DataStore<string>();
            ds1[0] = "one"; ds1[1] = "two"; ds1[2] = "three";

            for (int i = 0; i < 3; i++)
                Console.WriteLine(ds1[i]);

            DataStore<int> ds2 = new DataStore<int>();
            ds2[0] = 1; ds2[1] = 2; ds2[2] = 3;

            for (int i = 0; i < 3; i++)
                Console.WriteLine(ds2[i]);
        }
    }
}
