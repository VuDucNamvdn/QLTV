using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    class SQLManager
    {
        //Ket noi SQL
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader sqlReader;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable;

        //Truyền vào đoạn mã kết nối với database của sql
        public SQLManager(string dataSource)
        {
            connection = new SqlConnection(dataSource);
        }
        //Lấy giá trị gọi từ query vào bảng 
        public void getDataToDataGridView(string query, DataGridView dataGridTable)
        {
            var dataAdapter = new SqlDataAdapter(query, connection);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridTable.ReadOnly = true;
            dataGridTable.DataSource = ds.Tables[0];
            return;
        }
        //Chạy các query k cần output
        public void runqueryWithoutOutput(string query)
        {
            try
            {
                command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Chạy query với đầu ra bảng dữ liệu
        public DataSet getDataFromQuery(string query)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            return ds;
        }
        //Chạy query ra list string
        public List<string> stringDataFromQuery(string query)
        {
            command = new SqlCommand(query, connection);
            connection.Open();
            sqlReader = command.ExecuteReader();

            List<string> data = new List<string>();
            while (sqlReader.Read())
            {
                data.Add(sqlReader[0].ToString());
                //strValue=myreader["email"].ToString();
                //strValue=myreader.GetString(0);
            }
            connection.Close();
            return data;
        }
    }
}
