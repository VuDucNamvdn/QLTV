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
    }
}
