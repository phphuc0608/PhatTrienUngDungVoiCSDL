﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    class Xuly
    {
        public static string con = "Data Source=LAPTOP-QSVTM45F\\SQLSERVER;Initial Catalog=De7;Integrated Security=True";
        public static DataTable ExcuteQuery (string query)
    {
        DataTable data = new DataTable();
        using (SqlConnection connec = new SqlConnection(con))
        {
            connec.Open();
            SqlCommand command = new SqlCommand(query, connec);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
            connec.Close();

        }

        return data;

    }


    }
}
