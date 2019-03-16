using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace PDF323
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=test;Integrated Security=true";

            String sqlSelect = "SELECT * FROM emp";
            /*OleDbConnection conn = new OleDbConnection(conStr);
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sqlSelect, conn);
            DataSet ds = new DataSet("EMPLOYEES");
            // load data from the data source into the DataSet
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);*/


            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();

            // start the transaction
            SqlTransaction tran = conn.BeginTransaction();
            SqlDataAdapter da = new SqlDataAdapter(sqlSelect, conn);

            

            DataSet ds = new DataSet("EMPLOYEES");

            da.SelectCommand.Transaction = tran;

            da.Fill(ds, "EMP");



            Console.WriteLine("FILL 건수 : " + ds.Tables["EMP"].Rows.Count);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            // associate transaction with the data adapter command objects
            da.DeleteCommand = cb.GetDeleteCommand();
            da.InsertCommand = cb.GetInsertCommand();
            da.UpdateCommand = cb.GetUpdateCommand();

            da.DeleteCommand.Transaction = tran;
            da.InsertCommand.Transaction = tran;
            da.UpdateCommand.Transaction = tran;

            // modify
            ds.Tables["EMP"].Rows[0]["ename"] = "0길동";
            ds.Tables["EMP"].Rows[1]["ename"] = "1길동";
            //delete
            Console.WriteLine("삭제 대상 : " + ds.Tables["EMP"].Rows[9]["ename"]);
            ds.Tables["EMP"].Rows[9].Delete();
            //insert
            DataRow r = ds.Tables["EMP"].NewRow();
            r[0] = 1119; r[1] = "JCLEE";
            ds.Tables["EMP"].Rows.Add(r);
            try
            {
                ds.AcceptChanges();
                Console.WriteLine(ds.GetXml());
                da.Update(ds, "EMP");
                // commit if successful
                tran.Commit();
                Console.WriteLine("Commit OK~");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                tran.Rollback();
            }
            finally
            {
                conn.Close();
            }           
        }
    }
}
    