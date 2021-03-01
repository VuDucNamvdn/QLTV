
namespace QLTV.Login
{
    partial class Signup
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pwInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.iDInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signupBTN = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Panel();
            this.exitBTN = new System.Windows.Forms.Button();
            this.minimizeBTN = new System.Windows.Forms.Button();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 39);
            this.label4.TabIndex = 20;
            this.label4.Text = "Thêm tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 39);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phần mềm quản lý thư viện";
            // 
            // pwInput
            // 
            this.pwInput.Location = new System.Drawing.Point(96, 269);
            this.pwInput.Name = "pwInput";
            this.pwInput.PasswordChar = '*';
            this.pwInput.Size = new System.Drawing.Size(232, 20);
            this.pwInput.TabIndex = 18;
            this.pwInput.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 14);
            this.label2.TabIndex = 17;
            this.label2.Text = "PASSWORD: ";
            // 
            // iDInput
            // 
            this.iDInput.Location = new System.Drawing.Point(96, 243);
            this.iDInput.Name = "iDInput";
            this.iDInput.Size = new System.Drawing.Size(232, 20);
            this.iDInput.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID: ";
            // 
            // signupBTN
            // 
            this.signupBTN.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signupBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBTN.Location = new System.Drawing.Point(146, 383);
            this.signupBTN.Name = "signupBTN";
            this.signupBTN.Size = new System.Drawing.Size(100, 40);
            this.signupBTN.TabIndex = 14;
            this.signupBTN.Text = "Thêm";
            this.signupBTN.UseVisualStyleBackColor = true;
            this.signupBTN.Click += new System.EventHandler(this.signupBTN_Click);
            // 
            // title
            // 
            this.title.Controls.Add(this.minimizeBTN);
            this.title.Controls.Add(this.exitBTN);
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(400, 28);
            this.title.TabIndex = 21;
            // 
            // exitBTN
            // 
            this.exitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.exitBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitBTN.FlatAppearance.BorderSize = 0;
            this.exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBTN.ForeColor = System.Drawing.Color.Ivory;
            this.exitBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBTN.Location = new System.Drawing.Point(362, 0);
            this.exitBTN.Margin = new System.Windows.Forms.Padding(2);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(38, 28);
            this.exitBTN.TabIndex = 5;
            this.exitBTN.Text = "X";
            this.exitBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBTN.UseVisualStyleBackColor = false;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // minimizeBTN
            // 
            this.minimizeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(252)))));
            this.minimizeBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeBTN.FlatAppearance.BorderSize = 0;
            this.minimizeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBTN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBTN.ForeColor = System.Drawing.Color.Ivory;
            this.minimizeBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.minimizeBTN.Location = new System.Drawing.Point(324, 0);
            this.minimizeBTN.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBTN.Name = "minimizeBTN";
            this.minimizeBTN.Size = new System.Drawing.Size(38, 28);
            this.minimizeBTN.TabIndex = 6;
            this.minimizeBTN.Text = "-";
            this.minimizeBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.minimizeBTN.UseVisualStyleBackColor = false;
            this.minimizeBTN.Click += new System.EventHandler(this.minimizeBTN_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pwInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iDInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signupBTN);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.Text = "Signup";
            this.title.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox iDInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signupBTN;
        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Button minimizeBTN;
        private System.Windows.Forms.Button exitBTN;
    }
}