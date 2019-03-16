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

namespace AddrBook
{
    public partial class FrmListView : Form
    {
        private OleDbConnection LocalConn;

        public FrmListView()
        {
            InitializeComponent();
        }

        public void LoadData(DataTable dt)
        {
            listView1.Items.Clear();

            foreach (DataRow dtr in dt.Rows)
            {
                ListViewItem myitem1 = new ListViewItem(dtr["Name"].ToString());
                myitem1.SubItems.Add(dtr["Sex"].ToString());
                myitem1.SubItems.Add(dtr["Addr"].ToString());
                myitem1.SubItems.Add(dtr["Tel"].ToString());

                listView1.Items.Add(myitem1);
            }
        }

        private void FrmListView_Load(object sender, EventArgs e)
        {
            LocalConn = Common_DB.DBConnection();
            LocalConn.Open();
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter("select * from addrbook", LocalConn);
            DataSet ds = new DataSet();

            thisAdapter.Fill(ds, "addrbook");
            DataTable dt = ds.Tables["addrbook"];

            LoadData(dt);         
        }
    }
}
