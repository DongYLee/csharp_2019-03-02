using System;
using System.Windows.Forms;

namespace PDF277
{
    class Program : Form
    {
        static void Main(string[] args)
        {
            Button button1 = new Button();
            button1.Text = "Message";
            button1.Left = 50;
            button1.Top = 50;
            button1.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Button Click~");
            };

            Button button2 = new Button();
            button2.Text = "Exit";
            button2.Left = 150;
            button2.Top = 50;

            button2.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Will be terminated...");
                Application.Exit();
            };

            Program p = new Program();
            p.Text = "Winform Button example";
            p.Height = 150;
            p.Controls.Add(button1);
            p.Controls.Add(button2);
            Application.Run(p);
        }
    }
}