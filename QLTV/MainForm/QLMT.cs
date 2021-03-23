﻿using System;
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
            IDMTtxtBox.ReadOnly = true;
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
            rentDetailTB.Columns[2].HeaderText = "Số lượng sách";
            rentDetailTB.Columns[3].HeaderText = "Tình trạng";
            rentDetailTB.Columns[4].HeaderText = "Ngày trả";
            mydefine.ResizeDataTB(rentDetailTB);
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string idMT = sQLManager.stringDataFromQuery("exec ThemMT @MaDocGia ='" + iDDGtxtBox.Text + "', @NgayHetHan = '" + expiryDate.Value.Date.ToString("yyyy-MM-dd") + "'")[0];
            MessageBox.Show(idMT);
            foreach(DataGridViewRow row in bookToRentTB.Rows)
            {
                sQLManager.runqueryWithoutOutput("exec ThemDMT @MaMuonTra = '"+idMT+"',@MaSach ='"+row.Cells[0].Value.ToString() +"',@SL ='"+ row.Cells[3].Value.ToString() + "',@NgayTra=null");
            }
        }
    }
}
