using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTV.MainForm;

namespace QLTV
{
    public partial class QLTVForm : DraggableForm
    {
        private Button currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        private int role;
        public QLTVForm(string iD,int _Role)
        {
            InitializeComponent();
            #region Tinh chỉnh giao diện
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //Khung tài khoản
            userNamelabel.Text = iD;
            role = _Role;
            mydefine.SizeLabelFont(userNamelabel);
            if(role != 0)
            {
                addUser.Hide();
            }
            if (role == 0)
            {
                settingBTN.Hide();
            }
            ActivateButton(homeBTN, mydefine.color3);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            #endregion
        }

        #region Đổi màu phím
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Ivory;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        #endregion
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            lblTitleChildForm.Text = "Trang chủ";
        }

        private void qldgBTN_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, mydefine.color1);
            OpenChildForm(new QLDG());
        }

        private void helperBTN_Click(object sender, EventArgs e)
        {
            
        }

        private void qlmtBTN_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, mydefine.color6);
            OpenChildForm(new QLMT());
        }
        private void qlsBTN_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, mydefine.color5);
            OpenChildForm(new QLSach());
        }
        private void exitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homeBTN_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender, mydefine.color3);
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void minimizeBTN_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            new Account.Signup().ShowDialog();
        }

        private void settingBTN_Click(object sender, EventArgs e)
        {
            new Account.AccountSettingsForm(userNamelabel.Text).ShowDialog();
        }
    }
}
