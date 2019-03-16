using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace PDF317_Consile
{
    class Program
    {
        static OleDbConnection cn;
        static void Main(string[] args)
        {
            OleCn();
            Openning();
            Console.WriteLine("The Origianl Table");
            Output();

            Console.WriteLine("Added Table"); Adding(); Output();
            Console.WriteLine("Modifed Table"); Modifying(); Output();
            Console.WriteLine("Deleted Table"); Deleting(); Output();
            Closing();
        }

        public static void OleCn()
        {
            string OleCnString = @"Provider=SQLOLEDB;Data Source=localhost\SQLEXPRESS;Initial Catalog=test;Integrated Security=SSPI";
            cn = new OleDbConnection(OleCnString);
        }

        public static void Openning() { cn.Open();}
        public static void Output()
        {
            string sql = "SELECT empno id, ename name FROM emp";
            OleDbCommand cmd;
            OleDbDataReader dr;
            cmd = new OleDbCommand(sql, cn);
            dr = cmd.ExecuteReader();

            Console.Write("\n"); dr.Close();
            while (dr.Read())
            {
                Console.WriteLine("{0, -10]\t{1,-10)", dr[0].ToString().Trim(), dr[1].ToString().Trim());
            }
            Console.Write("\n");  dr.Close();
        }

        public static void Adding()
        {
            try
            {
                string sqladd = "INSERT INTO emp(empno, ename) VALUSE (888, 'ojc')";
                OleDbCommand cmdAdd = new OleDbCommand(sqladd, cn);
                int rowsadded = cmdAdd.ExecuteNonQuery();
                Console.Write("Numver of rows addedL " + rowsadded);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public static void Modifying()
        {
            try
            {
                string sqlmodify = "UPDATE emp SET ename = '오닷넷' WHERE empno = 888";
                OleDbCommand cmdupdate = new OleDbCommand(sqlmodify, cn);
                int rows = cmdupdate.ExecuteNonQuery();
                Console.WriteLine("Number of rows modified: " + rows);
            }
            catch (Exception e)
            { Console.WriteLine(e.ToString()); }
        }
        public static void Deleting()
        {
            try
            {
                string sqldelete = "DELETE FROM emp WHERE empno = 888 ";
                OleDbCommand cmddelete = new OleDbCommand(sqldelete, cn);
                int rows = cmddelete.ExecuteNonQuery();
                Console.WriteLine("Number of rows deleted: " + rows);
            }
            catch (Exception e)
            { Console.WriteLine(e.ToString()); }
        }
        public static void Closing() { cn.Close(); }
    }
}


        