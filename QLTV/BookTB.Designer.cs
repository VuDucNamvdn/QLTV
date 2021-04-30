
namespace QLTV
{
    partial class BookTB
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
            this.cancelBTN = new System.Windows.Forms.Button();
            this.confirmBTN = new System.Windows.Forms.Button();
            this.bookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.delFromRentBTN = new System.Windows.Forms.Button();
            this.addToRentBTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bookToAddTB = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookAddedToRentTB = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookToAddTB)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookAddedToRentTB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cancelBTN);
            this.panel1.Controls.Add(this.confirmBTN);
            this.panel1.Controls.Add(this.bookID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.delFromRentBTN);
            this.panel1.Controls.Add(this.addToRentBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 300);
            this.panel1.TabIndex = 0;
            // 
            // cancelBTN
            // 
            this.cancelBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBTN.Location = new System.Drawing.Point(82, 257);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(73, 38);
            this.cancelBTN.TabIndex = 15;
            this.cancelBTN.Text = "Hủy";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // confirmBTN
            // 
            this.confirmBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.confirmBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmBTN.Location = new System.Drawing.Point(10, 257);
            this.confirmBTN.Name = "confirmBTN";
            this.confirmBTN.Size = new System.Drawing.Size(73, 38);
            this.confirmBTN.TabIndex = 14;
            this.confirmBTN.Text = "Xác nhận";
            this.confirmBTN.UseVisualStyleBackColor = true;
            this.confirmBTN.Click += new System.EventHandler(this.confirmBTN_Click);
            // 
            // bookID
            // 
            this.bookID.Location = new System.Drawing.Point(99, 53);
            this.bookID.Name = "bookID";
            this.bookID.Size = new System.Drawing.Size(55, 20);
            this.bookID.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã đầu sách:";
            // 
            // delFromRentBTN
            // 
            this.delFromRentBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.delFromRentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delFromRentBTN.Location = new System.Drawing.Point(16, 155);
            this.delFromRentBTN.Name = "delFromRentBTN";
            this.delFromRentBTN.Size = new System.Drawing.Size(139, 38);
            this.delFromRentBTN.TabIndex = 11;
            this.delFromRentBTN.Text = "Xóa khỏi danh sách mượn";
            this.delFromRentBTN.UseVisualStyleBackColor = true;
            this.delFromRentBTN.Click += new System.EventHandler(this.delFromRentBTN_Click);
            // 
            // addToRentBTN
            // 
            this.addToRentBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.addToRentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToRentBTN.Location = new System.Drawing.Point(16, 107);
            this.addToRentBTN.Name = "addToRentBTN";
            this.addToRentBTN.Size = new System.Drawing.Size(139, 38);
            this.addToRentBTN.TabIndex = 10;
            this.addToRentBTN.Text = "Thêm vào danh sách mượn";
            this.addToRentBTN.UseVisualStyleBackColor = true;
            this.addToRentBTN.Click += new System.EventHandler(this.addToRentBTN_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel2.Controls.Add(this.bookToAddTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(168, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(382, 150);
            this.panel2.TabIndex = 1;
            // 
            // bookToAddTB
            // 
            this.bookToAddTB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.bookToAddTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookToAddTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookToAddTB.Location = new System.Drawing.Point(5, 5);
            this.bookToAddTB.Name = "bookToAddTB";
            this.bookToAddTB.Size = new System.Drawing.Size(372, 140);
            this.bookToAddTB.TabIndex = 0;
            this.bookToAddTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookToAddTB_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panel3.Controls.Add(this.bookAddedToRentTB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(168, 150);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(382, 150);
            this.panel3.TabIndex = 2;
            // 
            // bookAddedToRentTB
            // 
            this.bookAddedToRentTB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.bookAddedToRentTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookAddedToRentTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookAddedToRentTB.Location = new System.Drawing.Point(5, 5);
            this.bookAddedToRentTB.Name = "bookAddedToRentTB";
            this.bookAddedToRentTB.Size = new System.Drawing.Size(372, 140);
            this.bookAddedToRentTB.TabIndex = 0;
            this.bookAddedToRentTB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookAddedToRentTB_CellClick);
            // 
            // BookTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(550, 300);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookTB";
            this.Text = "BookTB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookToAddTB)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookAddedToRentTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView bookToAddTB;
        private System.Windows.Forms.Button addToRentBTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView bookAddedToRentTB;
        private System.Windows.Forms.Button delFromRentBTN;
        private System.Windows.Forms.TextBox bookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmBTN;
        private System.Windows.Forms.Button cancelBTN;
    }
}