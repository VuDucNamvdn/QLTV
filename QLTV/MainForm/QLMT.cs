using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.MainForm
{
    public partial class QLMT : Form
    {
        SQLManager sQLManager;
        public QLMT()
        {
            InitializeComponent();
            try
            {
                sQLManager = new SQLManager(mydefine.dataSource);
                UpdateRentingTB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateRentingTB()
        {
            sQLManager.getDataToDataGridView("select * from MuonTra", rentingDataTB);
            rentingDataTB.Columns[0].HeaderText = "Mã mượn trả";
            rentingDataTB.Columns[1].HeaderText = "Mã độc giả";
            rentingDataTB.Columns[2].HeaderText = "Hạn trả";
            mydefine.ResizeDataTB(rentingDataTB);
        }

        private void addBookToRentListBTN_Click(object sender, EventArgs e)
        {
            new BookTB(bookToRentTB).ShowDialog();
        }

        private void rentingDataTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                IDMTtxtBox.Text = rentingDataTB.Rows[e.RowIndex].Cells[0].Value.ToString();
                iDDGtxtBox.Text = rentingDataTB.Rows[e.RowIndex].Cells[1].Value.ToString();
                expiryDate.Value = Convert.ToDateTime(rentingDataTB.Rows[e.RowIndex].Cells[2].Value.ToString());


                var data = sQLManager.getDataFromQuery("SELECT TenDocGia from DocGia where MaDocGia = N'"+ iDDGtxtBox.Text + "'");
                NameDGtxtBox.Text = data.Tables[0].Rows[0]["TenDocGia"].ToString();
                UpdateRentDetailTB();
            }
            catch
            {

            }
        }

        private void UpdateRentDetailTB()
        {
            sQLManager.getDataToDataGridView("exec LayDMT '" + IDMTtxtBox.Text + "'", rentDetailTB);
            rentDetailTB.Columns[0].HeaderText = "Mã sách";
            rentDetailTB.Columns[1].HeaderText = "Tên sách";
            rentDetailTB.Columns[2].HeaderText = "Tình trạng";
            rentDetailTB.Columns[3].HeaderText = "Ngày trả";
            mydefine.ResizeDataTB(rentDetailTB);
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if(bookToRentTB.Rows.Count < 1)
            {
                MessageBox.Show("Chưa thêm sách để cho mượn");
                return;
            }    
            string idMT = sQLManager.stringDataFromQuery("exec ThemMT @MaDocGia ='" + iDDGtxtBox.Text + "', @NgayHetHan = '" + expiryDate.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "'")[0];
            foreach(DataGridViewRow row in bookToRentTB.Rows)
            {
                if(row.Cells[0].Value == null)
                {
                    continue;
                }    
                sQLManager.runqueryWithoutOutput("exec ThemDMT @MaMuonTra = '"+idMT+"',@MaSach ='"
                                                    +row.Cells[0].Value.ToString() +"',@SL ='1',@NgayTra=null");
            }
            UpdateRentingTB();
            UpdateRentDetailTB();
        }

        private void delBTN_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(IDMTtxtBox.Text))
            {
                MessageBox.Show("Mã mượn trả trống");
                return;
            }    
            sQLManager.runqueryWithoutOutput("exec XoaMT @MaMuonTra = '" + IDMTtxtBox.Text + "'");
            UpdateRentingTB();
            UpdateRentDetailTB();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sQLManager.runqueryWithoutOutput("exec XacNhanTra @MaMuonTra = '" + IDMTtxtBox.Text + "',@MaSach = '" + bookID.Text + "',@NgayTra = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")+"'");
            UpdateRentDetailTB();
        }

        private void rentDetailTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bookID.Text = rentDetailTB.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            sQLManager.runqueryWithoutOutput("exec SuaMT @MaMuonTra = '" + IDMTtxtBox.Text + "', @MaDocGia ='" + iDDGtxtBox.Text + "', @NgayHetHan = '" + expiryDate.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "'");
            UpdateRentingTB();
            UpdateRentDetailTB();
        }

        private void editDMT_Click(object sender, EventArgs e)
        {
            sQLManager.runqueryWithoutOutput("exec SuaD_MT @MaMuonTra = '" + IDMTtxtBox.Text + "', @MaSach ='" + newBookID.Text + "'" + ", @MaSachBanDau ='" + bookID.Text + "'");
            UpdateRentDetailTB();
        }

        private void delDMT_Click(object sender, EventArgs e)
        {
            sQLManager.runqueryWithoutOutput("exec XoaD_MT @MaMuonTra = '" + IDMTtxtBox.Text + "', @MaSach ='" + bookID.Text + "'");
            UpdateRentingTB();
            UpdateRentDetailTB();
        }

        private void searchForRentingInfoBTN_Click(object sender, EventArgs e)
        {
            sQLManager.getDataToDataGridView("select * from MuonTra where MaMuonTra ='" + searchBar.Text + "'", rentingDataTB);
            mydefine.ResizeDataTB(rentingDataTB);
        }
    }
}
