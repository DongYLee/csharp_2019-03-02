using System;

namespace ConsoleApp17
{
    interface Dog
    {
        string name { get; set; }
        void jitda();
    }
    class Pudle : Dog
    {
        public string name { get; set; }
        public void work() { Console.WriteLine(name + " 일한다."); }
        public void jitda() { Console.WriteLine(name + " 푸들푸들 짖다~~~~."); }
    }
    class Jindo : Dog
    {
        public string name { get; set; }
        public void run() { Console.WriteLine(name + " 달린다."); }
        public void jitda() { Console.WriteLine(name + " 진도진도 짖다~~~~."); }
    }
    class Program
    {
        static void Main()
        {
            Dog p = new Pudle(); p.name = "푸들이"; p.jitda(); ((Pudle)p).work();
            Dog j = new Jindo(); j.name = "진도이"; j.jitda(); ((Jindo)j).run();
        }
    }
}
