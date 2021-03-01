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
        public SQLManager(string dataSource)
        {
            connection = new SqlConnection(dataSource);
        }
        public void getDataToDataGridView(string query, DataGridView dataGridTable)
        {
            var dataAdapter = new SqlDataAdapter(query, connection);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridTable.ReadOnly = true;
            dataGridTable.DataSource = ds.Tables[0];

            //Store the number of columns in a variable
            int columnCount = dataGridTable.Columns.Count;

            //If we want the last column to fill the remaining space
            int lastColumnIndex = columnCount - 1;
            foreach (DataGridViewColumn column in dataGridTable.Columns)
            {
                if (column.Index == columnCount - lastColumnIndex) //Last column will fill extra space
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else //Any other column will be sized based on the max content size
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
            return;
        }

        public void runProcWithoutOutput(string query)
        {
            command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
