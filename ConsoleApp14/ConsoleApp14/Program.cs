using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Dog
    {
        public string name { get; set; }
        public void jitda()
        {
            Console.WriteLine(name + "가 짖다.");
        }
    }

    public class Pudle : Dog
    {
        public void work() { Console.WriteLine(name + "가 일 한다."); }
    }
    public class Jindo : Dog
    {
        public void run() { Console.WriteLine(name + "가 달린다. "); }
    }

    class DogManager
    {
        static void Main()
        {
            /*Pudle p = new Pudle(); p.name = "푸들이"; p.jitda(); p.work();*/
            Dog p = new Pudle();
            p.name = "푸들이";
            p.jitda();
            ((Pudle)p).work();
            Jindo j = new Jindo(); j.name = "진도이"; j.jitda(); j.run();
        }
    }
}




