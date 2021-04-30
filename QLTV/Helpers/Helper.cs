using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpers
{
    public partial class Helper : Form
    {
        Button CurrentButton;
        public Helper()
        {
            InitializeComponent();
            btnClick(addStHelperBTN);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER,CATSTATE.READER);
        }
        void btnClick(Button btn)
        {
            if (CurrentButton == null)
            {
                CurrentButton = btn;
                Utilities.setButtonState(true, ref CurrentButton);
                return;
            }
            if (CurrentButton == btn)
                return;
            Utilities.setButtonState(false, ref CurrentButton);
            CurrentButton = btn;
            Utilities.setButtonState(true, ref CurrentButton);
        }
        #region READER
        private void addStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER,CATSTATE.READER);
        }

        private void editStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.READER);
        }

        private void delStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.READER);
        }

        private void searchStHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.SEARCHHELPER, CATSTATE.READER);
        }
        #endregion
        #region LENDING
        private void addLENDINGHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER, CATSTATE.LENDING);
        }

        private void editLENDINGHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.LENDING);
        }

        private void delLENDINGHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.LENDING);
        }

        private void searchLENDINGHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.SEARCHHELPER, CATSTATE.LENDING);
        }
        #endregion
        #region BOOL
        private void addBOOKHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.ADDHELPER, CATSTATE.BOOK);
        }

        private void editBOOKHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.EDITHELPER, CATSTATE.BOOK);
        }

        private void delBOOKHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.DELETEHELPER, CATSTATE.BOOK);
        }

        private void searchBOOKHelperBTN_Click(object sender, EventArgs e)
        {
            btnClick((Button)sender);
            helpBox.updateInformation(HELPERSTATE.SEARCHHELPER, CATSTATE.BOOK);
        }
        #endregion
    }
}
