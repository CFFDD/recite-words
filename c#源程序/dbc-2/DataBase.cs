using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student2008
{
    class DataBase
    {
        public SqlConnection dataConnection = new SqlConnection();
        public SqlDataAdapter dataAdapter;
        public DataSet dataset = new DataSet();
        //  String connStr = "server=theone-pc;database=SelectCourse;integrated=security=SSPI";
        String connStr = "Data Source=.;Initial Catalog=bdc;Integrated Security=True";
        public DataSet GetDataFormDB(string sqlStr)//用于实现查询
        {
            try
            {
                dataConnection.ConnectionString = connStr;
                dataAdapter = new SqlDataAdapter(sqlStr, dataConnection);
                dataset.Clear();
                dataAdapter.Fill(dataset);
                dataConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                dataConnection.Close();

            }
            if (dataset.Tables[0].Rows.Count != 0)
                return dataset;
            else
                return null;
        }
        public bool UpdateDB(string sqlStr)//用于实现更新（数据的插入，修改，删除）
        {
            SqlConnection sqlConn = new SqlConnection(connStr);
            try
            {
                SqlCommand cmdTable = new SqlCommand(sqlStr, sqlConn);
                cmdTable.CommandType = CommandType.Text;
                sqlConn.Open();
                cmdTable.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                sqlConn.Close();
            }
        }

    }
}

