namespace WindowsFormsApplication2
{
    partial class QL_Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_QLN = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.QLN_date = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QLN_Nguon = new System.Windows.Forms.TextBox();
            this.QLN_SL = new System.Windows.Forms.TextBox();
            this.QLN_TenHang = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.QLX_linkTim = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.NgayXuat = new System.Windows.Forms.DateTimePicker();
            this.NoiXuat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QLX_boxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkHD = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_QLN.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_QLN);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 236);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_QLN
            // 
            this.tab_QLN.Controls.Add(this.dataGridView1);
            this.tab_QLN.Controls.Add(this.button1);
            this.tab_QLN.Controls.Add(this.QLN_date);
            this.tab_QLN.Controls.Add(this.label5);
            this.tab_QLN.Controls.Add(this.label4);
            this.tab_QLN.Controls.Add(this.label3);
            this.tab_QLN.Controls.Add(this.label2);
            this.tab_QLN.Controls.Add(this.label1);
            this.tab_QLN.Controls.Add(this.QLN_Nguon);
            this.tab_QLN.Controls.Add(this.QLN_SL);
            this.tab_QLN.Controls.Add(this.QLN_TenHang);
            this.tab_QLN.Location = new System.Drawing.Point(4, 22);
            this.tab_QLN.Name = "tab_QLN";
            this.tab_QLN.Padding = new System.Windows.Forms.Padding(3);
            this.tab_QLN.Size = new System.Drawing.Size(431, 210);
            this.tab_QLN.TabIndex = 0;
            this.tab_QLN.Text = "Nhập hàng";
            this.tab_QLN.UseVisualStyleBackColor = true;
            this.tab_QLN.Click += new System.EventHandler(this.tab_QLN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLN_date
            // 
            this.QLN_date.Location = new System.Drawing.Point(67, 123);
            this.QLN_date.Name = "QLN_date";
            this.QLN_date.Size = new System.Drawing.Size(100, 20);
            this.QLN_date.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Loại hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nguồn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên hàng";
            // 
            // QLN_Nguon
            // 
            this.QLN_Nguon.Location = new System.Drawing.Point(67, 90);
            this.QLN_Nguon.Name = "QLN_Nguon";
            this.QLN_Nguon.Size = new System.Drawing.Size(100, 20);
            this.QLN_Nguon.TabIndex = 2;
            this.QLN_Nguon.Text = "Rang dong";
            // 
            // QLN_SL
            // 
            this.QLN_SL.Location = new System.Drawing.Point(67, 63);
            this.QLN_SL.Name = "QLN_SL";
            this.QLN_SL.Size = new System.Drawing.Size(100, 20);
            this.QLN_SL.TabIndex = 1;
            this.QLN_SL.Text = "5";
            // 
            // QLN_TenHang
            // 
            this.QLN_TenHang.Location = new System.Drawing.Point(67, 33);
            this.QLN_TenHang.Name = "QLN_TenHang";
            this.QLN_TenHang.Size = new System.Drawing.Size(100, 20);
            this.QLN_TenHang.TabIndex = 0;
            this.QLN_TenHang.Text = "den ban";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.QLX_linkTim);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.QLX_boxID);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(431, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xuất hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(272, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Thông tin xuất hàng";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "ok";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QLX_linkTim
            // 
            this.QLX_linkTim.AutoSize = true;
            this.QLX_linkTim.Location = new System.Drawing.Point(151, 17);
            this.QLX_linkTim.Name = "QLX_linkTim";
            this.QLX_linkTim.Size = new System.Drawing.Size(20, 13);
            this.QLX_linkTim.TabIndex = 6;
            this.QLX_linkTim.TabStop = true;
            this.QLX_linkTim.Text = "tìm";
            this.QLX_linkTim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.QLX_linkTim_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.NgayXuat);
            this.panel2.Controls.Add(this.NoiXuat);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.SoLuong);
            this.panel2.Location = new System.Drawing.Point(212, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 132);
            this.panel2.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ngày xuất";
            // 
            // NgayXuat
            // 
            this.NgayXuat.Location = new System.Drawing.Point(63, 85);
            this.NgayXuat.Name = "NgayXuat";
            this.NgayXuat.Size = new System.Drawing.Size(134, 20);
            this.NgayXuat.TabIndex = 7;
            // 
            // NoiXuat
            // 
            this.NoiXuat.Location = new System.Drawing.Point(63, 44);
            this.NoiXuat.Name = "NoiXuat";
            this.NoiXuat.Size = new System.Drawing.Size(134, 20);
            this.NoiXuat.TabIndex = 6;
            this.NoiXuat.Text = "Ha Noi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nơi xuất";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số lượng";
            // 
            // SoLuong
            // 
            this.SoLuong.Location = new System.Drawing.Point(63, 3);
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(134, 20);
            this.SoLuong.TabIndex = 4;
            this.SoLuong.Text = "3";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(6, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 132);
            this.panel1.TabIndex = 2;
            // 
            // QLX_boxID
            // 
            this.QLX_boxID.Location = new System.Drawing.Point(61, 10);
            this.QLX_boxID.Name = "QLX_boxID";
            this.QLX_boxID.Size = new System.Drawing.Size(83, 20);
            this.QLX_boxID.TabIndex = 1;
            this.QLX_boxID.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã hàng";
            // 
            // linkHD
            // 
            this.linkHD.AutoSize = true;
            this.linkHD.Location = new System.Drawing.Point(392, 9);
            this.linkHD.Name = "linkHD";
            this.linkHD.Size = new System.Drawing.Size(60, 13);
            this.linkHD.TabIndex = 1;
            this.linkHD.TabStop = true;
            this.linkHD.Text = "Hướng dẫn";
            this.linkHD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHD_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(181, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(238, 94);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(200, 132);
            this.dataGridView2.TabIndex = 0;
            // 
            // QL_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 298);
            this.Controls.Add(this.linkHD);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QL_Form";
            this.Text = "QL_Form";
            this.tabControl1.ResumeLayout(false);
            this.tab_QLN.ResumeLayout(false);
            this.tab_QLN.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_QLN;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QLN_Nguon;
        private System.Windows.Forms.TextBox QLN_SL;
        private System.Windows.Forms.TextBox QLN_TenHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker QLN_date;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox QLX_boxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel QLX_linkTim;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker NgayXuat;
        private System.Windows.Forms.TextBox NoiXuat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkHD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}