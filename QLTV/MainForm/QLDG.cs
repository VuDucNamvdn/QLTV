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

            List<string> mtID = sQLManager.stringDataFromQuery("select MaMuonTra from MuonTra where MaDocGia ='" + IDtxtBox.Text + "'");
            
            //Xóa hết khóa ngoại trong bảng MuonTra
            foreach(var id in mtID)
                sQLManager.runqueryWithoutOutput("exec XoaMT @MaMuonTra = '" + id + "'");


            //Xóa độc giả trong bảng Docgia
            sQLManager.runqueryWithoutOutput( "delete from Docgia where MaDocGia ='" + IDtxtBox.Text + "'");
            

            //In lại ra datagridview
            UpdateDGTB();
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            sQLManager.runqueryWithoutOutput("Insert into Docgia values( N'" + NametxtBox.Text + "','" + expiryDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' )");
            UpdateDGTB();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
          
            sQLManager.runqueryWithoutOutput("Update Docgia set TenDocGia = N'" + NametxtBox.Text + "', NgayHetHan = '" + expiryDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' where MaDocGia = '"+ IDtxtBox.Text + "'");
            UpdateDGTB();
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            sQLManager.getDataToDataGridView("select * from DocGia where MaDocGia Like'%" + searchBar.Text+"%'", docGiaDataTB);
            mydefine.ResizeDataTB(docGiaDataTB);
        }
    }
}
