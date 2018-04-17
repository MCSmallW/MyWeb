using System;
using System.Collections.Generic;
using System.Data;
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

            }

            return dt;
        }
    }
}
