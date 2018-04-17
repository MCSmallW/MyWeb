using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Helper
{
    public class SQLHelper
    {
        public static DataTable SQLToDT(string connectionString,string commandText)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(dt);
            }
            return dt;
        }
    }
}
