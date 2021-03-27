using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV;
using System.Data.SqlClient;

namespace QLTV.MainForm
{
    public partial class QLDG : Form
    {
        SQLManager sQLManager;
        public QLDG()
        {
            InitializeComponent();
            IDtxtBox.ReadOnly = true;
            try
            {
                sQLManager = new SQLManager(mydefine.dataSource);
                UpdateDGTB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDGTB()
        {
            sQLManager.getDataToDataGridView("select * from DocGia", docGiaDataTB);
            mydefine.ResizeDataTB(docGiaDataTB);
        }

        private void getRowData(DataGridViewCellEventArgs e)
        {
            IDtxtBox.Text = docGiaDataTB.Rows[e.RowIndex].Cells[0].Value.ToString();
            NametxtBox.Text = docGiaDataTB.Rows[e.RowIndex].Cells[1].Value.ToString();
            expiryDate.Value = Convert.ToDateTime(docGiaDataTB.Rows[e.RowIndex].Cells[2].Value.ToString());
        }

        private void docGiaDataTB_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                getRowData(e);
            }
            catch { }
        }

        private void delBTN_Click(object sender, EventArgs e)
        {
            sQLManager.command = sQLManager.connection.CreateCommand();

            //Xóa khóa ngoại trong bảng MuonTra
            sQLManager.runqueryWithoutOutput( "delete from MuonTra where MaDocGia = '" + IDtxtBox.Text + "'");


            //Xóa độc giả trong bảng Docgia
            sQLManager.runqueryWithoutOutput( "delete from Docgia where MaDocGia ='" + IDtxtBox.Text + "'");
            

            //In lại ra datagridview
            UpdateDGTB();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(mydefine.dataSource);
            //string id = IDtxtBox.Text;
            connection.Open();


            string sql = "select * from Docgia where MaDocGia = '" + IDtxtBox.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, connection);

            SqlDataReader dta = cmd.ExecuteReader();
            if (dta.Read() == true)
            {

                MessageBox.Show(" Trùng mã! Mời Nhập lại");
            }
            else
            {
                dta.Close();

                sQLManager.runqueryWithoutOutput("Insert into Docgia values( N'" + NametxtBox.Text + "','" + expiryDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' )");
                UpdateDGTB();
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
          
            sQLManager.runqueryWithoutOutput("Update Docgia set TenDocGia = N'" + NametxtBox.Text + "', NgayHetHan = '" + expiryDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' where MaDocGia = '"+ IDtxtBox.Text + "'");
            UpdateDGTB();
        }
    }
}
