namespace QLTV
{
    partial class QLTVForm
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDown = new System.Windows.Forms.Panel();
            this.exitBTN = new System.Windows.Forms.Button();
            this.qldsBTN = new System.Windows.Forms.Button();
            this.qldgBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTile = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.qlmtBTN = new System.Windows.Forms.Button();
            this.helperBTN = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelDown.SuspendLayout();
            this.panelTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.helperBTN);
            this.panelMenu.Controls.Add(this.qlmtBTN);
            this.panelMenu.Controls.Add(this.panelDown);
            this.panelMenu.Controls.Add(this.qldsBTN);
            this.panelMenu.Controls.Add(this.qldgBTN);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(188, 547);
            this.panelMenu.TabIndex = 0;
            // 
            // panelDown
            // 
            this.panelDown.Controls.Add(this.exitBTN);
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 506);
            this.panelDown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(188, 41);
            this.panelDown.TabIndex = 4;
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitBTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.exitBTN.FlatAppearance.BorderSize = 0;
            this.exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBTN.ForeColor = System.Drawing.Color.Ivory;
            this.exitBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBTN.Location = new System.Drawing.Point(0, 0);
            this.exitBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(38, 41);
            this.exitBTN.TabIndex = 4;
            this.exitBTN.Text = "X";
            this.exitBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // qldsBTN
            // 
            this.qldsBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.qldsBTN.FlatAppearance.BorderSize = 0;
            this.qldsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qldsBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qldsBTN.ForeColor = System.Drawing.Color.Ivory;
            this.qldsBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qldsBTN.Location = new System.Drawing.Point(0, 163);
            this.qldsBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qldsBTN.Name = "qldsBTN";
            this.qldsBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.qldsBTN.Size = new System.Drawing.Size(188, 49);
            this.qldsBTN.TabIndex = 2;
            this.qldsBTN.Text = "Quản lý đầu sách";
            this.qldsBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qldsBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.qldsBTN.UseVisualStyleBackColor = true;
            this.qldsBTN.Click += new System.EventHandler(this.qldsBTN_Click);
            // 
            // qldgBTN
            // 
            this.qldgBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.qldgBTN.FlatAppearance.BorderSize = 0;
            this.qldgBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qldgBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qldgBTN.ForeColor = System.Drawing.Color.Ivory;
            this.qldgBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qldgBTN.Location = new System.Drawing.Point(0, 114);
            this.qldgBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.qldgBTN.Name = "qldgBTN";
            this.qldgBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.qldgBTN.Size = new System.Drawing.Size(188, 49);
            this.qldgBTN.TabIndex = 1;
            this.qldgBTN.Text = "Quản lý độc giả";
            this.qldgBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qldgBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.qldgBTN.UseVisualStyleBackColor = true;
            this.qldgBTN.Click += new System.EventHandler(this.qldgBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 114);
            this.panel1.TabIndex = 0;
            // 
            // panelTile
            // 
            this.panelTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTile.Controls.Add(this.lblTitleChildForm);
            this.panelTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTile.Location = new System.Drawing.Point(188, 0);
            this.panelTile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTile.Name = "panelTile";
            this.panelTile.Size = new System.Drawing.Size(698, 65);
            this.panelTile.TabIndex = 1;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Ivory;
            this.lblTitleChildForm.Location = new System.Drawing.Point(4, 16);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(153, 39);
            this.lblTitleChildForm.TabIndex = 0;
            this.lblTitleChildForm.Text = "Trang chủ";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(188, 65);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(698, 8);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(188, 73);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(698, 474);
            this.panelDesktop.TabIndex = 3;
            // 
            // qlmtBTN
            // 
            this.qlmtBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.qlmtBTN.FlatAppearance.BorderSize = 0;
            this.qlmtBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qlmtBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlmtBTN.ForeColor = System.Drawing.Color.Ivory;
            this.qlmtBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qlmtBTN.Location = new System.Drawing.Point(0, 212);
            this.qlmtBTN.Margin = new System.Windows.Forms.Padding(2);
            this.qlmtBTN.Name = "qlmtBTN";
            this.qlmtBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.qlmtBTN.Size = new System.Drawing.Size(188, 49);
            this.qlmtBTN.TabIndex = 5;
            this.qlmtBTN.Text = "Quản lý mượn trả";
            this.qlmtBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.qlmtBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.qlmtBTN.UseVisualStyleBackColor = true;
            this.qlmtBTN.Click += new System.EventHandler(this.qlmtBTN_Click);
            // 
            // helperBTN
            // 
            this.helperBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.helperBTN.FlatAppearance.BorderSize = 0;
            this.helperBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helperBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helperBTN.ForeColor = System.Drawing.Color.Ivory;
            this.helperBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helperBTN.Location = new System.Drawing.Point(0, 261);
            this.helperBTN.Margin = new System.Windows.Forms.Padding(2);
            this.helperBTN.Name = "helperBTN";
            this.helperBTN.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.helperBTN.Size = new System.Drawing.Size(188, 49);
            this.helperBTN.TabIndex = 6;
            this.helperBTN.Text = "Hướng dẫn sử dụng";
            this.helperBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.helperBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.helperBTN.UseVisualStyleBackColor = true;
            this.helperBTN.Click += new System.EventHandler(this.helperBTN_Click);
            // 
            // QLTVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 547);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTile);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "QLTVForm";
            this.Text = "QLTVForm";
            this.panelMenu.ResumeLayout(false);
            this.panelDown.ResumeLayout(false);
            this.panelTile.ResumeLayout(false);
            this.panelTile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button qldgBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button qldsBTN;
        private System.Windows.Forms.Panel panelTile;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button helperBTN;
        private System.Windows.Forms.Button qlmtBTN;
    }
}