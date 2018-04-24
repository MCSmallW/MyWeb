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
        SqlConnection conn;

        //连接数据库
        private void OpenConnection()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("数据库连接失败：" + ex.Message);
            }
        }
        //关闭数据库连接
        private void CloseConnection()
        {
            if(conn.State==ConnectionState.Open)
            {
                conn.Close();
            }
        }

        //执行数据库语句
        private void OperateSql(string sql)
        {
            OpenConnection();
            try
            {
                SqlCommand sqlCom = new SqlCommand(sql, conn);
                sqlCom.ExecuteNonQuery();
                sqlCom.Dispose();
            }
            catch(Exception ex)
            {
                throw new Exception("执行SQL语句失败：" + ex.Message);
            }
            CloseConnection();
        }

        //生成DataTable
        public DataTable GetDataTable(string sql)
        {
            OpenConnection();
            DataTable dt;
            SqlDataAdapter dataAdapter;
            try
            {
                dataAdapter = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("返回dt失败：" + ex.Message);
            }
            CloseConnection();
            return dt;
        }
        //判断是否管理员
        public DataTable IfAdmin(string sql,string Admin)
        {
            OpenConnection();
            DataTable dt;
            SqlDataAdapter dataAdapter;
            try
            {
                dataAdapter = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("返回dt失败：" + ex.Message);
            }
            CloseConnection();
            return dt;
        }
        //获取报表列表json数据
        public DataTable GetReportList(string sql)
        {
            OpenConnection();
            DataTable dt;
            SqlDataAdapter dataAdapter;
            try
            {
                dataAdapter = new SqlDataAdapter(sql, conn);
                dt = new DataTable();
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("返回列表出错：" + ex.Message);
            }
            CloseConnection();
            return dt;
        }
        
    }
}
