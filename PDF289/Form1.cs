using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF289
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Modalless Window";
            f.Width = 200; f.Height = 100; f.BackColor = Color.Black;
            f.Show();
        }

        private void btnModal_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            f.Text = "Modal Window";
            f.Width = 200; f.Height = 100; f.BackColor = Color.Blue;
            f.ShowDialog();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("abc", "def", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
