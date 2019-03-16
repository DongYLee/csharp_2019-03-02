using System;
using System.Data;
using System.Data.SqlClient;

class Sample
{
    public static void Main()
    {
        SqlConnection thisConnection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS; Initial Catalog=test; Integrated Security=true");
        thisConnection.Open();

        SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT empno, ename from emp", thisConnection);
        SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);

        Console.WriteLine("SQL SELECT Command is:\n{0}\n", thisAdapter.SelectCommand.CommandText);

        SqlCommand updateCommand = thisBuilder.GetUpdateCommand();
        Console.WriteLine("SQL UPDATE Command is:\n{0}\n", updateCommand.CommandText);

        SqlCommand insertCommand = thisBuilder.GetInsertCommand();
        Console.WriteLine("SQL INSERT Command is:\n{0}\n", insertCommand.CommandText);

        SqlCommand deleteCommand = thisBuilder.GetDeleteCommand();
        Console.WriteLine("SQL DELETE Command is:\n{0}", deleteCommand.CommandText);
        thisConnection.Close();
    }
}