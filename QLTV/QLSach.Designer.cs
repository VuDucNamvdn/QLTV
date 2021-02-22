namespace QLTV
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IDtxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NametxtBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addBTN = new System.Windows.Forms.Button();
            this.delBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.CategoryBox = new System.Windows.Forms.ComboBox();
            this.nOfBook = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nOfBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1182, 673);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(5, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 400);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1172, 263);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1172, 252);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.nOfBook);
            this.panel5.Controls.Add(this.CategoryBox);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.IDtxtBox);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.NametxtBox);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 400);
            this.panel5.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sách: ";
            // 
            // IDtxtBox
            // 
            this.IDtxtBox.Location = new System.Drawing.Point(121, 26);
            this.IDtxtBox.Name = "IDtxtBox";
            this.IDtxtBox.Size = new System.Drawing.Size(133, 20);
            this.IDtxtBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sách: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thể loại: ";
            // 
            // NametxtBox
            // 
            this.NametxtBox.Location = new System.Drawing.Point(121, 54);
            this.NametxtBox.Name = "NametxtBox";
            this.NametxtBox.Size = new System.Drawing.Size(133, 20);
            this.NametxtBox.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addBTN);
            this.panel4.Controls.Add(this.delBTN);
            this.panel4.Controls.Add(this.updateBTN);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(865, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(307, 400);
            this.panel4.TabIndex = 11;
            // 
            // addBTN
            // 
            this.addBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBTN.Location = new System.Drawing.Point(184, 3);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(116, 40);
            this.addBTN.TabIndex = 6;
            this.addBTN.Text = "Thêm";
            this.addBTN.UseVisualStyleBackColor = true;
            // 
            // delBTN
            // 
            this.delBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delBTN.Location = new System.Drawing.Point(184, 97);
            this.delBTN.Name = "delBTN";
            this.delBTN.Size = new System.Drawing.Size(116, 40);
            this.delBTN.TabIndex = 7;
            this.delBTN.Text = "Xóa";
            this.delBTN.UseVisualStyleBackColor = true;
            // 
            // updateBTN
            // 
            this.updateBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.updateBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBTN.Location = new System.Drawing.Point(184, 51);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(116, 40);
            this.updateBTN.TabIndex = 8;
            this.updateBTN.Text = "Sửa";
            this.updateBTN.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số lượng trên kệ: ";
            // 
            // CategoryBox
            // 
            this.CategoryBox.FormattingEnabled = true;
            this.CategoryBox.Location = new System.Drawing.Point(121, 79);
            this.CategoryBox.Name = "CategoryBox";
            this.CategoryBox.Size = new System.Drawing.Size(133, 21);
            this.CategoryBox.TabIndex = 8;
            // 
            // nOfBook
            // 
            this.nOfBook.Location = new System.Drawing.Point(121, 105);
            this.nOfBook.Name = "nOfBook";
            this.nOfBook.Size = new System.Drawing.Size(120, 20);
            this.nOfBook.TabIndex = 9;
            // 
            // QLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1182, 673);
            this.Controls.Add(this.panel1);
            this.Name = "QLSach";
            this.Text = "Quản lý sách";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nOfBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox CategoryBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NametxtBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button delBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.NumericUpDown nOfBook;
    }
}