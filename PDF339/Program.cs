using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PDF339
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=localhost\SQLEXPRESS; Initial Catalog = test; Integrated Security = true";
            SqlConnection conn = new SqlConnection(conStr);
            SqlDataAdapter adapter = new SqlDataAdapter("select * from emp", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            DataSet ds = new DataSet();

            adapter.Fill(ds, "사원");

            Console.WriteLine("Data Count : {0}", ds.Tables["사원"].Rows.Count);            DataColumn[] keys = new DataColumn[1];
            keys[0] = ds.Tables["사원"].Columns["empno"];
            ds.Tables["사원"].PrimaryKey = keys;            DataRow findrow = ds.Tables["사원"].Rows.Find(7369);            if (findrow != null)
            {
                findrow.Delete();
                adapter.Update(ds, "사원");
                //삭제 후 데이터 출력
                foreach (DataRow row in ds.Tables["사원"].Rows)
                {
                    foreach (DataColumn col in ds.Tables["사원"].Columns)
                        Console.Write("{0, -10}", row[col.ColumnName]);
                }
                Console.WriteLine();
            }
        }
    }
}
