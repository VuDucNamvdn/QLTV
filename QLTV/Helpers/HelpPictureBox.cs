using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpers
{
    public partial class HelpPictureBox : UserControl
    {
        Graphics g;
        int currentIndex = 0;
        int[,] maxIndex = new int[3, 4] { { 1, 2, 1, 1 }, { 2, 2, 1, 1 } , { 1, 2, 1, 1 } };
        HELPERSTATE currentState = HELPERSTATE.ADDHELPER;
        CATSTATE currentObjectToRef = CATSTATE.READER;
        string[,] helpStringREADER = new string[4, 3] 
        { 
            { "B1: Điền thông tin độc giả cần thêm vào các bảng", 
                "B2: Nhấp chuột trái vào nút Thêm để thêm độc giả vào cơ sở dữ liệu","" }, 
            { "B1: Nhấp chuột trái 2 lần vào dòng độc giả cần sửa trong bảng hoặc gõ mã độc giả vào trong ô", 
              "B2: Thay đổi thông tin ở trên các bảng",
              "B3: Nhấp chuột trái vào nút Sửa để cập nhập lại thông tin độc giả" },
            { "B1: Nhấp chuột trái 2 lần vào dòng độc giả cần xoá", 
              "B2: Nhấp chuột trái vào nút Xoá để xoá độc giả khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin độc giả cần tìm kiếm vào bảng", 
              "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các độc giả tương đồng với thông tin đã nhập","" }
        };
        string[,] helpStringBOOK = new string[4, 3]
        {
            { "B1: Điền thông tin sách cần thêm vào các bảng",
              "B2: Nhấp chuột trái vào nút Thêm để thêm sách vào cơ sở dữ liệu","" },
            { "B1: Nhấp chuột trái 2 lần vào dòng sách cần sửa trong bảng hoặc gõ mã sách vào trong ô",
              "B2: Thay đổi thông tin ở trên các bảng",
              "B3: Nhấp chuột trái vào nút Sửa để cập nhập lại thông tin sách" },
            { "B1: Nhấp chuột trái 2 lần vào dòng sách cần xoá",
              "B2: Nhấp chuột trái vào nút Xoá để xoá sách khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin sách cần tìm kiếm vào bảng",
              "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các sách tương đồng với thông tin đã nhập","" }
        };
        string[,] helpStringLENDING = new string[4, 3]
        {
            { "B1: Nhấp chuột để nhập danh sách sách cho mượn", 
              "B2: Chọn sách và cho vào danh sách, nhấn xác nhận để lưu hoặc hủy danh sách ",
              "B3: Điền thông tin phiếu mượn mã độc giả và hạn phải trả và xác nhận để lưu phiếu mượn" },
            { "B1: Nhấp chuột trái 2 lần vào dòng mượn trả cần sửa trong bảng hoặc gõ mã mượn trả vào trong ô",
              "B2: Thay đổi thông tin ở trên các bảng",
              "B3: Nhấp chuột trái vào các nút Sửa để cập nhập lại thông tin mượn trả" },
            { "B1: Nhấp chuột trái 2 lần vào dòng mượn trả cần xoá", 
              "B2: Nhấp chuột trái vào nút Xoá để xoá mượn trả khỏi cơ sở dữ liệu","" },
            { "B1: Điền thông tin mượn trả cần tìm kiếm vào bảng", 
              "B2: Nhấp chuột trái vào nút tìm kiếm để in ra thông tin của các mượn trả tương đồng với thông tin đã nhập","" }
        };
        public HelpPictureBox()
        {
            InitializeComponent();
            g = progressBar.CreateGraphics();
            progressBar.Paint += progressPaint;
        }

        private void progressPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            float percentage = 1f / (maxIndex[(int)currentObjectToRef, (int)currentState] + 1);
            int width = Convert.ToInt32(progressBar.Width * percentage);
            Rectangle rectangle = new Rectangle(0, 0, width, progressBar.Height);
            SolidBrush brush = new SolidBrush(Color.Red);

            e.Graphics.FillRectangle(brush, rectangle);
        }

        private void setImage(string filename)
        {
            switch(currentObjectToRef)
            {
                case CATSTATE.READER:
                    helpLabel.Text = helpStringREADER[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\READER" + filename);
                    break;
                case CATSTATE.LENDING:
                    helpLabel.Text = helpStringLENDING[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\LENDING" + filename);
                    break;
                case CATSTATE.BOOK:
                    helpLabel.Text = helpStringBOOK[(int)currentState, currentIndex];
                    checkLabeOverflow();
                    helperPic.Image = Image.FromFile(Application.StartupPath + "\\Image\\BOOK" + filename);
                    break;
            }   

            helperPic.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void updateInformation(HELPERSTATE state,CATSTATE catstate, int index = 0)
        {
            //Pass
            if (index > maxIndex[(int)catstate, (int)currentState] || index < 0) return;

            index = QLTV.mydefine.Clamp(ref index, 0, maxIndex[(int)catstate, (int)currentState]);
            currentIndex = index;
            currentState = state;
            currentObjectToRef = catstate;
            FillProgressBar(index);
            switch (state)
            {
                case HELPERSTATE.ADDHELPER:
                    setImage("\\add" + index + ".png");
                    return;
                case HELPERSTATE.DELETEHELPER:
                    setImage("\\del" + index + ".png");
                    return;
                case HELPERSTATE.EDITHELPER:
                    setImage("\\edit" + index + ".png");
                    return;
                case HELPERSTATE.SEARCHHELPER:
                    setImage("\\search" + index + ".png");
                    return;
            }
        }

        private void FillProgressBar(int index)
        {
            g.Clear(Color.White);
            float percentage = (float)(index + 1) / ( maxIndex[(int)currentObjectToRef, (int)currentState] + 1);
            int width = Convert.ToInt32(progressBar.Width * percentage);
            Rectangle rectangle = new Rectangle(0, 0, width, progressBar.Height);

            SolidBrush brush = new SolidBrush(Color.Red);
            
            g.FillRectangle(brush, rectangle);
        }

        private void previousBTN_Click(object sender, EventArgs e)
        {
            updateInformation(currentState,currentObjectToRef ,currentIndex - 1);
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            updateInformation(currentState, currentObjectToRef, currentIndex + 1);
        }

        void checkLabeOverflow()
        {
            while (helpLabel.Width < System.Windows.Forms.TextRenderer.MeasureText(helpLabel.Text,
            new Font(helpLabel.Font.FontFamily, helpLabel.Font.Size, helpLabel.Font.Style)).Width)
            {
                helpLabel.Font = new Font(helpLabel.Font.FontFamily, helpLabel.Font.Size - 0.5f, helpLabel.Font.Style);
            }
        }

        private void helperPic_Resize(object sender, EventArgs e)
        {
            checkLabeOverflow();
        }
    }
}
