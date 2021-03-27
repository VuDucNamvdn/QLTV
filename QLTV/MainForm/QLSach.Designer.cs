
namespace QLTV.MainForm
{
    partial class QLSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLSach));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.them = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.searchForBookBTN = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nOfBook = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.IDtxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NametxtBox = new System.Windows.Forms.TextBox();
            this.bookDataTB = new System.Windows.Forms.DataGridView();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOfBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button1);
            this.panel9.Controls.Add(this.them);
            this.panel9.Controls.Add(this.button3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 481);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.panel9.Size = new System.Drawing.Size(424, 71);
            this.panel9.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(160, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // them
            // 
            this.them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.them.Location = new System.Drawing.Point(20, 16);
            this.them.Margin = new System.Windows.Forms.Padding(4);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(107, 47);
            this.them.TabIndex = 9;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(301, 16);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 47);
            this.button3.TabIndex = 13;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.searchForBookBTN);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.nOfBook);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.CategoryBox);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.IDtxtBox);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.NametxtBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(426, 554);
            this.panel5.TabIndex = 13;
            // 
            // searchForBookBTN
            // 
            this.searchForBookBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.searchForBookBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchForBookBTN.Image = ((System.Drawing.Image)(resources.GetObject("searchForBookBTN.Image")));
            this.searchForBookBTN.Location = new System.Drawing.Point(209, 167);
            this.searchForBookBTN.Margin = new System.Windows.Forms.Padding(4);
            this.searchForBookBTN.Name = "searchForBookBTN";
            this.searchForBookBTN.Size = new System.Drawing.Size(40, 37);
            this.searchForBookBTN.TabIndex = 19;
            this.searchForBookBTN.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 175);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 22);
            this.textBox2.TabIndex = 9;
            // 
            // nOfBook
            // 
            this.nOfBook.Location = new System.Drawing.Point(124, 107);
            this.nOfBook.Margin = new System.Windows.Forms.Padding(4);
            this.nOfBook.Name = "nOfBook";
            this.nOfBook.Size = new System.Drawing.Size(160, 22);
            this.nOfBook.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tìm kiếm thông tin sách: ";
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(124, 75);
            this.CategoryBox.Margin = new System.Windows.Forms.Padding(4);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(176, 24);
            this.CategoryBox.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Số lượng tồn: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mã sách: ";
            // 
            // IDtxtBox
            // 
            this.IDtxtBox.Location = new System.Drawing.Point(124, 10);
            this.IDtxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.IDtxtBox.Name = "IDtxtBox";
            this.IDtxtBox.Size = new System.Drawing.Size(176, 22);
            this.IDtxtBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tên sách: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 78);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Thể loại: ";
            // 
            // NametxtBox
            // 
            this.NametxtBox.Location = new System.Drawing.Point(124, 44);
            this.NametxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.NametxtBox.Name = "NametxtBox";
            this.NametxtBox.Size = new System.Drawing.Size(176, 22);
            this.NametxtBox.TabIndex = 13;
            // 
            // bookDataTB
            // 
            this.bookDataTB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.bookDataTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bookDataTB.DefaultCellStyle = dataGridViewCellStyle1;
            this.bookDataTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookDataTB.Location = new System.Drawing.Point(426, 0);
            this.bookDataTB.Margin = new System.Windows.Forms.Padding(4);
            this.bookDataTB.Name = "bookDataTB";
            this.bookDataTB.ReadOnly = true;
            this.bookDataTB.RowHeadersWidth = 51;
            this.bookDataTB.Size = new System.Drawing.Size(1058, 554);
            this.bookDataTB.TabIndex = 15;
            this.bookDataTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookDataTB_CellClick);
            // 
            // QLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1484, 554);
            this.Controls.Add(this.bookDataTB);
            this.Controls.Add(this.panel5);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QLSach";
            this.Text = "Quản lý sách";
            this.panel9.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOfBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDataTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button searchForBookBTN;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown nOfBook;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IDtxtBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NametxtBox;
        private System.Windows.Forms.DataGridView bookDataTB;
    }
}