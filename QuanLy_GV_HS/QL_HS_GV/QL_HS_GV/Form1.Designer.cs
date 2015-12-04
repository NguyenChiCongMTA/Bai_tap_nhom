namespace QL_HS_GV
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.bntDangnhap = new System.Windows.Forms.Button();
            this.bntDangki = new System.Windows.Forms.Button();
            this.bntHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thông tin tài khoản";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(120, 112);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(115, 20);
            this.textPass.TabIndex = 10;
            this.textPass.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(120, 76);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(115, 20);
            this.textID.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập";
            // 
            // texEmail
            // 
            this.texEmail.Location = new System.Drawing.Point(120, 150);
            this.texEmail.Name = "texEmail";
            this.texEmail.Size = new System.Drawing.Size(115, 20);
            this.texEmail.TabIndex = 12;
            this.texEmail.UseSystemPasswordChar = true;
            this.texEmail.Visible = false;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(33, 153);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "Email";
            this.lbEmail.Visible = false;
            // 
            // bntDangnhap
            // 
            this.bntDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDangnhap.Location = new System.Drawing.Point(52, 200);
            this.bntDangnhap.Name = "bntDangnhap";
            this.bntDangnhap.Size = new System.Drawing.Size(75, 23);
            this.bntDangnhap.TabIndex = 13;
            this.bntDangnhap.Text = "Đăng nhập";
            this.bntDangnhap.UseVisualStyleBackColor = true;
            this.bntDangnhap.Click += new System.EventHandler(this.bntDangnhap_Click);
            // 
            // bntDangki
            // 
            this.bntDangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntDangki.Location = new System.Drawing.Point(159, 200);
            this.bntDangki.Name = "bntDangki";
            this.bntDangki.Size = new System.Drawing.Size(75, 23);
            this.bntDangki.TabIndex = 14;
            this.bntDangki.Text = "Đăng ký";
            this.bntDangki.UseVisualStyleBackColor = true;
            this.bntDangki.Click += new System.EventHandler(this.bntDangki_Click);
            // 
            // bntHelp
            // 
            this.bntHelp.Location = new System.Drawing.Point(237, 6);
            this.bntHelp.Name = "bntHelp";
            this.bntHelp.Size = new System.Drawing.Size(38, 22);
            this.bntHelp.TabIndex = 15;
            this.bntHelp.Text = "button1";
            this.bntHelp.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bntHelp);
            this.Controls.Add(this.bntDangki);
            this.Controls.Add(this.bntDangnhap);
            this.Controls.Add(this.texEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button bntDangnhap;
        private System.Windows.Forms.Button bntDangki;
        private System.Windows.Forms.Button bntHelp;
    }
}

