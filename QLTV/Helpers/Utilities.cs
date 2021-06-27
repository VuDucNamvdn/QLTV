using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Helpers
{
    public enum CATSTATE : int
    {
        READER = 0,
        LENDING = 1,
        BOOK = 2,

    }
    public enum HELPERSTATE : int
    {
        ADDHELPER = 0,
        EDITHELPER = 1,
        DELETEHELPER = 2,
        SEARCHHELPER = 3
    }
    class Utilities
    {
        static Color baseButtonBackColor = Color.FromArgb(53, 54, 104);
        static Color activeButtonBackColor = Color.FromArgb(33, 34, 64);
        static Color baseButtonForeColor = Color.White;
        static Color activeButtonForeColor = Color.White;
        public static void setButtonState(bool bIsActive, ref Button btn)
        {
            if(bIsActive)
            {
                btn.BackColor = activeButtonBackColor;
                btn.ForeColor = activeButtonForeColor;
            }
            else
            {
                btn.BackColor = baseButtonBackColor;
                btn.ForeColor = baseButtonForeColor;
            }
        }
    }
	class define    
    {
        public const string dataSource = @"Data Source=DESKTOP-9JCB5HS;Initial Catalog=QuanLyKhachSan;Integrated Security=True";
    }
}
