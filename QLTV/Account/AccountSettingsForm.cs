using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.Account
{
    public partial class AccountSettingsForm : DraggableForm
    {
        SQLManager sQLManager;
        private string iD;
        public AccountSettingsForm(string id)
        {
            InitializeComponent();
            iD = id;
            try
            {
                sQLManager = new SQLManager(mydefine.dataSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void confirmBTN_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(newpwInput.Text))
            {
                MessageBox.Show("Chưa nhập password");
                return;
            }
            try
            {
                string password = EncryptionHelper.Encrypt(newpwInput.Text);
                string query = "UPDATE DangNhap SET MatKhau = N'"+ password + "' WHERE MaNguoiDung = N'" + iD + "'";
                sQLManager.runqueryWithoutOutput(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            Close();
        }
        private void exitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
