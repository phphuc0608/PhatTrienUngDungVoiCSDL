using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApp1
{
    class Database
    {
        public static void Execute(string strCommand, Dictionary<string, object> parameters)
        {
            string strConnection = "Server=.\\MSSQLSERVER01;database=De02;integrated security=true;";
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            SqlCommand cmd = new SqlCommand(strCommand, connection);
            foreach (string key in parameters.Keys)
                cmd.Parameters.Add(new SqlParameter(key, parameters[key]));
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable Query(string strQuery, Dictionary<string, object> parameters)
        {
            string strConnection = "Server=.\\MSSQLSERVER01;database=De02;integrated security=true;";
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            SqlCommand cmd = new SqlCommand(strQuery, connection);
            foreach (string key in parameters.Keys)
                cmd.Parameters.Add(new SqlParameter(key, parameters[key]));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
