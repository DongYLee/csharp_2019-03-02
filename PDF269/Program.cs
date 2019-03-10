using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF269
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Program form = new Program();
            //form.Click += new EventHandler(form.Form_Click);
            form.Click += new EventHandler(
                (sender, eventArgs) =>
                {
                    Console.WriteLine("Form Click Event...");
                    Application.Exit();
                });
            Console.WriteLine("Windows start...");
            Application.Run(form);
            Console.WriteLine("Windows stop...");
        }

        void Form_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Form Click Event");
            Application.Exit();
        }
    }
}