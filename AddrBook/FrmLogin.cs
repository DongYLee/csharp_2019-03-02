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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private OleDbConnection LocalConn;

        private void button1_Click(object sender, EventArgs e)
        {           
            LocalConn = Common_DB.DBConnection();
            LocalConn.Open();

            OleDbDataAdapter thisAdapter = new OleDbDataAdapter("select * from member", LocalConn);
            DataSet ds = new DataSet();

            thisAdapter.Fill(ds, "member");
            DataTable dt = ds.Tables["member"];

            foreach (DataRow dtr in dt.Rows)
            {
                if (txtID.Text == dtr["id"].ToString())
                {
                    if (txtPWD.Text == dtr["pwd"].ToString())
                    {
                        MessageBox.Show("있어요");
                        FrmMDIMain m = new FrmMDIMain();
                        m.Show();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("비번이 틀렸군요");
                        return;
                    }
                }
            }
            MessageBox.Show("없어요.");

        /*
        OleDbDataReader myReader;
        string sql = null;
        try
        {
            LocalConn = Common_DB.DBConnection();
            LocalConn.Open();

            if (txtID.Text == "" || txtPWD.Text == "")
            {
                MessageBox.Show("ID 또는 Password를 입력 하세요...");
                return;
            }

            sql = "select pwd from member ";
            sql += " where id = " + "'" + txtID.Text + "'";

            myReader = Common_DB.DataSelect(sql, LocalConn);

            if (myReader.Read())
            {
                if (txtPWD.Text != myReader["pwd"].ToString())
                {
                    MessageBox.Show("Password가 맞지 않습니다...");
                    return;
                }
            }
            else
            {
                MessageBox.Show("등록되지 않은 ID 입니다.");
                return;
            }

            //----------- ID가 PWD가 맞는 경우
            FrmMDIMain m = new FrmMDIMain();
            m.Show();
            //m.Owner = this;
            //---------------------------------
            this.Hide();
            //Log.WriteLine("FrmLogin", "[로그인 :" + txtID.Text + "]");
        }
        catch (Exception e1)
        {
            //Log.WriteLine("FrmLogin", e1.ToString());
            //Log.WriteLine("FrmLogin", sql);
            MessageBox.Show("FrmLogin", "로그인 오류! " + sql);
        }
        */
    }
    }
}
