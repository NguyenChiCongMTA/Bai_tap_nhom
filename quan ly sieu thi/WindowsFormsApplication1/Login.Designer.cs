namespace WindowsFormsApplication1
{
    partial class Login
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
            this.main_pan_DN = new System.Windows.Forms.Panel();
            this.main_but_OK = new System.Windows.Forms.Button();
            this.main_box_pword = new System.Windows.Forms.TextBox();
            this.main_box_uname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_main = new System.Windows.Forms.Label();
            this.main_pan_DN.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_pan_DN
            // 
            this.main_pan_DN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.main_pan_DN.Controls.Add(this.main_but_OK);
            this.main_pan_DN.Controls.Add(this.main_box_pword);
            this.main_pan_DN.Controls.Add(this.main_box_uname);
            this.main_pan_DN.Controls.Add(this.label2);
            this.main_pan_DN.Controls.Add(this.label1);
            this.main_pan_DN.Location = new System.Drawing.Point(45, 75);
            this.main_pan_DN.Name = "main_pan_DN";
            this.main_pan_DN.Size = new System.Drawing.Size(616, 269);
            this.main_pan_DN.TabIndex = 0;
            // 
            // main_but_OK
            // 
            this.main_but_OK.Location = new System.Drawing.Point(210, 168);
            this.main_but_OK.Name = "main_but_OK";
            this.main_but_OK.Size = new System.Drawing.Size(75, 23);
            this.main_but_OK.TabIndex = 4;
            this.main_but_OK.Text = "Đăng nhập";
            this.main_but_OK.UseVisualStyleBackColor = true;
            this.main_but_OK.Click += new System.EventHandler(this.main_but_OK_Click);
            // 
            // main_box_pword
            // 
            this.main_box_pword.Location = new System.Drawing.Point(210, 129);
            this.main_box_pword.Name = "main_box_pword";
            this.main_box_pword.Size = new System.Drawing.Size(288, 20);
            this.main_box_pword.TabIndex = 3;
            // 
            // main_box_uname
            // 
            this.main_box_uname.Location = new System.Drawing.Point(210, 101);
            this.main_box_uname.Name = "main_box_uname";
            this.main_box_uname.Size = new System.Drawing.Size(288, 20);
            this.main_box_uname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên người dùng";
            // 
            // lab_main
            // 
            this.lab_main.AutoSize = true;
            this.lab_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_main.Location = new System.Drawing.Point(249, 15);
            this.lab_main.Name = "lab_main";
            this.lab_main.Size = new System.Drawing.Size(202, 42);
            this.lab_main.TabIndex = 1;
            this.lab_main.Text = "Đăng nhập";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 356);
            this.Controls.Add(this.lab_main);
            this.Controls.Add(this.main_pan_DN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.main_pan_DN.ResumeLayout(false);
            this.main_pan_DN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel main_pan_DN;
        private System.Windows.Forms.Button main_but_OK;
        private System.Windows.Forms.TextBox main_box_pword;
        private System.Windows.Forms.TextBox main_box_uname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_main;
    }
}

