using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF305
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                ds = new DataSet("emp");
                string conStr = @"Provider=SQLOLEDB;Data Source=localhost\SQLEXPRESS;Initial Catalog=test;Integrated Security=SSPI";

                conn = new OleDbConnection(conStr);
                conn.Open();
                OleDbCommand command = new OleDbCommand("insert into emp(empno,ename) values (8998, 'OJC')", conn);
                //command.ExecuteNonQuery();

                adapter = new OleDbDataAdapter("select * from emp", conn);
                //adapter = new OleDbDataAdapter("select * from emp where ename='OJC'", conn);
                
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "emp Table Loading Error");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
