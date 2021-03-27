using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV
{
    class mydefine
    {
        //Datasourse (khac nhau)
        public const string dataSource = @"Data Source=DESKTOP-9JCB5HS;Initial Catalog=QLTV;Integrated Security=True";
        public static int Clamp(ref int value, int min, int max)
        {
            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;

        }
        //Chỉnh sửa kích cỡ chữ cho vừa khung
        public static void SizeLabelFont(System.Windows.Forms.Label lbl)
        {
            while (lbl.Width < System.Windows.Forms.TextRenderer.MeasureText(lbl.Text,
                new Font(lbl.Font.FontFamily, lbl.Font.Size, lbl.Font.Style)).Width)
            {
                lbl.Font = new Font(lbl.Font.FontFamily, lbl.Font.Size - 0.5f, lbl.Font.Style);
            }
        }
        public static Color color1 = Color.FromArgb(172, 126, 241);
        public static Color color2 = Color.FromArgb(249, 118, 176);
        public static Color color3 = Color.FromArgb(253, 138, 114);
        public static Color color4 = Color.FromArgb(95, 77, 221);
        public static Color color5 = Color.FromArgb(249, 88, 155);
        public static Color color6 = Color.FromArgb(24, 161, 251);
        //Chỉnh lại kích cỡ bảng dữ liệu cho vừa khung
        public static void ResizeDataTB(DataGridView dataGridTable)
        {

            //Store the number of columns in a variable
            int columnCount = dataGridTable.Columns.Count;

            //If we want the last column to fill the remaining space
            int lastColumnIndex = columnCount - 1;
            foreach (DataGridViewColumn column in dataGridTable.Columns)
            {
                if (column.Index == columnCount - lastColumnIndex) //Last column will fill extra space
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else //Any other column will be sized based on the max content size
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

    }

}
