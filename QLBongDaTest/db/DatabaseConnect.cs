using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBongDaTest.db
{
    internal class DatabaseConnect
    {
        private readonly SqlConnection connect;
        private readonly String strConnect = @"Data Source=DESKTOP-EDMHBF2;Initial Catalog=QLyGiaiBongDa;Integrated Security=True";
        public DatabaseConnect() 
        {
            connect = new SqlConnection();
        }
        public bool Connect()
        {
            try
            {
                if (connect.State == ConnectionState.Closed || connect.State == ConnectionState.Broken)
                {
                    connect.ConnectionString = strConnect;
                    connect.Open();
                }
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public DataTable GetTableData(string tableName, string statement = "", string orderBy = "")
        {
            DataTable res = new DataTable();
            string strSQL = "Select * From " + tableName;
            if (statement != "") 
            { 
                strSQL += " Where " + statement;  
            }
            if (orderBy != "")
            {
                strSQL += " Order By " + orderBy;
            }
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(strSQL, connect);
            sqlAdapter.Fill(res);
            return res;
        }

        public DataTable GetTableData(string tableName)
        {
            DataTable res = new DataTable();
            string strSQL = "Select * From " + tableName;
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(strSQL, connect);
            sqlAdapter.Fill(res);
            return res;
        }

        public bool IsIdExist(string tableName, string statement)
        {
            string strSQL = "Select Count(*) From " + tableName + " Where " + statement;
            SqlCommand cmd = new SqlCommand(strSQL, connect);
            int res = (int)cmd.ExecuteScalar();
            return res == 0;
        }

        public bool Save(DataTable tbl, string tableName)
        {
            try
            {
                string strSQL = "Select * From " + tableName;
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(strSQL, connect);
                SqlCommandBuilder cmdBD = new SqlCommandBuilder(sqlAdapter);
                sqlAdapter.Update(tbl);
                return true;
            }
            catch
            {
                MessageBox.Show("Đã xảy ra lỗi cập nhật!");
                return false;
            }
        }
    }
}
