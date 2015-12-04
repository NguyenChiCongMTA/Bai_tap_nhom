namespace WindowsFormsApplication2
{
    partial class Login_Form
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Login_box_pword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_but_ok = new System.Windows.Forms.Button();
            this.Login_box_uname = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "ncc";
            // 
            // Login_box_pword
            // 
            this.Login_box_pword.Location = new System.Drawing.Point(133, 141);
            this.Login_box_pword.Name = "Login_box_pword";
            this.Login_box_pword.Size = new System.Drawing.Size(128, 20);
            this.Login_box_pword.TabIndex = 1;
            this.Login_box_pword.Text = "123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên người dùng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu";
            // 
            // Login_but_ok
            // 
            this.Login_but_ok.Location = new System.Drawing.Point(158, 228);
            this.Login_but_ok.Name = "Login_but_ok";
            this.Login_but_ok.Size = new System.Drawing.Size(75, 23);
            this.Login_but_ok.TabIndex = 4;
            this.Login_but_ok.Text = "Dang nhap";
            this.Login_but_ok.UseVisualStyleBackColor = true;
            this.Login_but_ok.Click += new System.EventHandler(this.Login_but_ok_Click);
            // 
            // Login_box_uname
            // 
            this.Login_box_uname.AutoSize = true;
            this.Login_box_uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_box_uname.Location = new System.Drawing.Point(110, 25);
            this.Login_box_uname.Name = "Login_box_uname";
            this.Login_box_uname.Size = new System.Drawing.Size(146, 31);
            this.Login_box_uname.TabIndex = 5;
            this.Login_box_uname.Text = "Đăng nhập";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(319, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(60, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Hướng dẫn";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 278);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Login_box_uname);
            this.Controls.Add(this.Login_but_ok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Login_box_pword);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox Login_box_pword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Login_but_ok;
        private System.Windows.Forms.Label Login_box_uname;
        private System.Windows.Forms.LinkLabel linkLabel1;

    }
}

