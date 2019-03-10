using System;
using System.Windows.Forms;

namespace PDF271
{

    class OnjMessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            const int WM_SYSKEYDOWN = 0x0104;

            if (m.Msg == 0x201)
            {
                Console.WriteLine("mouse click filtered...");
                return true;
            }
            if (m.Msg == WM_SYSKEYDOWN)
            {
                bool alt = ((int)m.LParam & 0x20000000) != 0;
                if (alt && (m.WParam == new IntPtr((int)Keys.F4)))
                    Console.WriteLine("ALT+F4 filtered...");
                return true; // 이벤트를 처리했으니 뒤쪽으로 넘기지 않는다.
            }
            return false;
        }
    }

    class Program : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new OnjMessageFilter());
            Program p = new Program();
            p.Click += p.Form_Click;
            Application.Run(p);
        }

        void Form_Click(object sender, EventArgs e)
        {
            Console.WriteLine("mouse click event...");
            Application.Exit();
        }
    }
}