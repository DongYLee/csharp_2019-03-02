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
    public partial class FrmDataGridView : Form
    {
        private OleDbConnection LocalConn;


        public FrmDataGridView()
        {
            InitializeComponent();
        }

        public void LoadData(DataTable dt)
        {
/*
            foreach (DataRow dtr in dt.Rows)
            {
                ListViewItem myitem1 = new ListViewItem(dtr["Name"].ToString());
                myitem1.SubItems.Add(dtr["Sex"].ToString());
                myitem1.SubItems.Add(dtr["Addr"].ToString());
                myitem1.SubItems.Add(dtr["Tel"].ToString());

                //listView1.Items.Add(myitem1);
            }*/
        }

        private void FrmDataGridView_Load(object sender, EventArgs e)
        {
                

            LocalConn = Common_DB.DBConnection();
            LocalConn.Open();
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter("select * from addrbook", LocalConn);
            DataSet ds = new DataSet();
            thisAdapter.Fill(ds, "addrbook");

            dataGrid1.DataSource = ds.Tables["addrbook"];

            dataGrid1.Columns[dataGrid1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGrid1.Columns[0].HeaderText = "이 름";
            dataGrid1.Columns[1].HeaderText = "성 별";
            dataGrid1.Columns[2].HeaderText = "주 소";
            dataGrid1.Columns[2].Width = 180;
            dataGrid1.Columns[3].HeaderText = "전화번호";

            


            /*DataTable dt = ds.Tables["addrbook"];

            LoadData(dt);*/
        }
    }
}
