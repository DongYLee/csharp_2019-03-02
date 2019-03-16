using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF162
{
    class EventPublisher
    {
        //public delegate void MyEventHandler();
        public event EventHandler MyEvent;
        public void Do()
        {
            if (MyEvent != null)
            {
                MyEvent(null, null);
            }            
        }
    }

    /*class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += doAction;

            p.Do();
        }*/

    class Subscriber
    {
        static void Main(string[] args)
        {
            EventPublisher p = new EventPublisher();
            p.MyEvent += new EventHandler(doAction);
            p.MyEvent += doAction;
            p.MyEvent += delegate (object sender, EventArgs e)
            { Console.WriteLine("MyEvent라는 이벤트 발생"); };
            p.MyEvent += (sender, e) =>
            { Console.WriteLine("MyEvent라는 이벤트 발생"); };
            p.Do();
        }

        static void doAction(object sender, EventArgs e)
        {
            Console.WriteLine("MyEvent라는 이벤트 발생...");
        }
    }
}