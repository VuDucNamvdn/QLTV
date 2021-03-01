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
    public partial class Signup : DraggableForm
    {
        SQLManager sQLManager;
        public Signup()
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

        private void signupBTN_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(iDInput.Text))
            {
                MessageBox.Show("Chưa nhập id");
                return;
            }
            if (String.IsNullOrEmpty(pwInput.Text))
            {
                MessageBox.Show("Chưa nhập password");
                return;
            }
            try
            {
                string password = EncryptionHelper.Encrypt(pwInput.Text);
                string query = "exec ThemTK @id = N'" + iDInput.Text + "', @pass = N'" + password + "', @role = '1'";
                sQLManager.runqueryWithoutOutput(query);
            }
            catch(Exception ex)
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
