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
    public partial class Login : DraggableForm
    {
        SQLManager sQLManager;
        public Login()
        {
            InitializeComponent();
            try
            {
                sQLManager = new SQLManager(mydefine.dataSource);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string query = "select * from DangNhap where MaNguoiDung = N'"+iDInput.Text+"'";
            var data=sQLManager.getDataFromQuery(query);            
            string password = EncryptionHelper.Decrypt(data.Tables[0].Rows[0]["MatKhau"].ToString());
            int userRole = (int)data.Tables[0].Rows[0]["Quyen"];
            string userID = data.Tables[0].Rows[0]["MaNguoiDung"].ToString();
            if (pwInput.Text==password)
            {
                new QLTVForm(userID, userRole).Show();
                Close();              
            }
        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
