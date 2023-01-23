using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Đề1
{
    class Xuly
    {
        private static string con = "Data Source=LAPTOP-QSVTM45F\\SQLSERVER;Initial Catalog=De1;Integrated Security=True";
        public static DataTable ExcuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connect = new SqlConnection(con))
            {
                connect.Open();
                SqlCommand com = new SqlCommand(query, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
        }
    }
}
