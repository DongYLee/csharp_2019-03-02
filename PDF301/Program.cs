using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace PDF301
{
    class Program
    {
        static void Main(string[] args)
        {
/*
// SQL을 사용한다. 
            string connectionString = 
                @"Data Source=localhost\SQLEXPRESS;
                Initial Catalog=test;
                Integrated Security=true"; // 윈도우인증을 사용함
                                                                                
            SqlConnection sqlConn = new SqlConnection(connectionString);
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlConn;

            sqlComm.CommandText =
                "select top 10 empno, ename, job, sal from emp" +
                "where job=@Job order by empno asc";  //@은 바인드변수처리한다. Oracle에서는 ? 입니다. 
            sqlComm.Parameters.AddWithValue("@Job", "Clerk");
            sqlConn.Open();

            SqlDataReader SqlRs;
            using (SqlRs = sqlComm.ExecuteReader(CommandBehavior.CloseConnection))  //자동자원관리 (SqlRs 를 닫기위해 사용한다.)
            {   
                Console.WriteLine("Empno | Ename | Job  | Sal");
                Console.WriteLine("-----------------------------");
                while (SqlRs.Read())
                {
                    Console.WriteLine($"{SqlRs[0]} | {SqlRs[1]} | {SqlRs[2]} | {SqlRs[3]}");
                }
            }
            SqlRs.Close();
            //sqlConn.Close();


            /// Oracle을 사용할 때
            /*
                        string str = "data source=topcredu;user id=scott; password=tiger";
                        OracleConnection Conn = new OracleConnection(str);
                        OracleCommand Comm;
                        Comm = new OracleCommand();
                        Comm.Connection = Conn;
                        try
                        {
                            Conn.Open();
                            Comm.CommandText = "SELECT ENAME FROM EMP";
                            OracleDataReader reader = Comm.ExecuteReader();
                            while (reader.Read())
                            {
                                Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                        finally
                        {
                            Conn.Close();
                        }
                        */

            //// 위 예제를 OleDbConnection을 이용한 방식으로 변경해보자.
            ///
            
            string conStr = @"Provider=SQLOLEDB;Data Source=localhost\SQLEXPRESS;Initial Catalog=test;Integrated Security=SSPI";

            OleDbConnection sqlConn = new OleDbConnection(conStr);
            OleDbCommand sqlComm = new OleDbCommand();
            sqlComm.Connection = sqlConn;

            sqlComm.CommandText = "select top 10 empno, ename, job, sal from emp " +
                                               "where job = ? " +
                                               "and sal > ? order by empno asc";
            sqlComm.Parameters.AddWithValue("@Job", "Clerk");
            sqlComm.Parameters.AddWithValue("@Sal", 800);
            sqlConn.Open();

            OleDbDataReader SqlRs;

            using (SqlRs = sqlComm.ExecuteReader(CommandBehavior.CloseConnection))
            {
                Console.WriteLine("Empno | Ename | Job  | Sal");
                Console.WriteLine("-----------------------------");
                while (SqlRs.Read())
                {
                    Console.WriteLine($"{SqlRs[0]} | {SqlRs[1]} | {SqlRs[2]} | {SqlRs[3]}");
                }
            }
            SqlRs.Close();
            //sqlConn.Close();            
        }
    }
}

