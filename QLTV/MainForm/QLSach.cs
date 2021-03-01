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
    public partial class QLSach : Form
    {
        SQLManager sQLManager;
        public QLSach()
        {
            InitializeComponent();
            try
            {
                sQLManager = new SQLManager(mydefine.dataSource);
                UpdateBookTB();
                UpdateCat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateBookTB()
        {
            sQLManager.getDataToDataGridView("exec LaySach", bookDataTB);
            bookDataTB.Columns[0].HeaderText = "Mã sách";
            bookDataTB.Columns[1].HeaderText = "Tên sách";
            bookDataTB.Columns[2].HeaderText = "Thể loại";
            bookDataTB.Columns[3].HeaderText = "Số lượng tồn";
            mydefine.ResizeDataTB(bookDataTB);
        }

        private void UpdateCat()
        {
            CategoryBox.Items.Clear();
            var data = sQLManager.getDataFromQuery("SELECT TenTheLoai from TheLoai");
            for(int i = 0; i< data.Tables[0].Rows.Count;i++ )
            {
                CategoryBox.Items.Add(data.Tables[0].Rows[i]["TenTheLoai"].ToString());
            }
        }
        private void bookDataTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDtxtBox.Text = bookDataTB.Rows[e.RowIndex].Cells[0].Value.ToString();
            NametxtBox.Text = bookDataTB.Rows[e.RowIndex].Cells[1].Value.ToString();
            string catName = bookDataTB.Rows[e.RowIndex].Cells[2].Value.ToString();
            for (int i = 0; i < CategoryBox.Items.Count; i++)
            {
                if (CategoryBox.Items[i].ToString() == catName)
                {
                    CategoryBox.SelectedIndex = i;
                    break;
                }
            }
            nOfBook.Value = (int)bookDataTB.Rows[e.RowIndex].Cells[3].Value;
        }
    }
}
