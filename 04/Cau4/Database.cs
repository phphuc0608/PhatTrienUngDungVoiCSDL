using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Cau4
{
    class Database
    {
        public static string strConnection = @"server=.\SQLEXPRESS;database=De4;integrated security=true";
        public static void Execute(string strCommand, Dictionary<string, object> parameters)
        {
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(strCommand, connection);
            foreach(string key in parameters.Keys)
            {
                command.Parameters.Add(new SqlParameter(key, parameters[key]));
            }
            command.ExecuteNonQuery();
            connection.Close();
        }
        public static DataTable Query(string strCommand, Dictionary<string,object> parameters)
        {
            SqlConnection connection = new SqlConnection(strConnection);
            connection.Open();
            SqlCommand command = new SqlCommand(strCommand, connection);
            foreach (string key in parameters.Keys)
            {
                command.Parameters.Add(new SqlParameter(key, parameters[key]));
            }
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            return table;
        }
    }
}
