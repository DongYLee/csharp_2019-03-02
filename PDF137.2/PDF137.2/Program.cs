using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF137._2
{
    class DataStore
    {
        private string[] strArr = new string[10];

        public DataStore() { }
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("cannot store more than 10 object.");
                return strArr[index];
            }
            set
            {
                if (index < 0 || index >= strArr.Length)
                    throw new IndexOutOfRangeException("cannot store more than 10 object.");
                strArr[index] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                foreach (string s in strArr)
                {
                    if (s.ToLower() == name.ToLower())
                        return s;
                }
                return null;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            {
                DataStore strStore = new DataStore();
                strStore[0] = "One";
                strStore[1] = "Two";
                strStore[2] = "Three";
                strStore[3] = "Four";
                Console.WriteLine(strStore["one"]);
                Console.WriteLine(strStore["two"]);
                Console.WriteLine(strStore["Three"]);
                Console.WriteLine(strStore["FOUR"]);
            }
        }
    }
}