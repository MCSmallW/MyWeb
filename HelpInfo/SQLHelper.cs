using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Helper
{
    public class SQLHelper
    {
        //Data Source=HP-PC;Initial Catalog=Test;Persist Security Info=True;User ID=sa;Password=123
        public static string connectionString = @"Data Source=HP-PC;Initial Catalog=Test;Persist Security Info=True;User ID=sa;Password=123";
        string commandText="";
        bool isRight = false;

        public bool SQLToDT(string name)
        {
            DataTable dt = new DataTable();
            commandText = "select fldPassWord from dbo.UserInfo where fldUserName='Test' and fldPassWord='123'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(commandText, conn);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    isRight = true;
                }
            }
            return isRight;
        }
    }
}
