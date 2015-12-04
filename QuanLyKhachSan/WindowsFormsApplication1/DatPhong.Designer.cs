namespace WindowsFormsApplication1
{
    partial class DPform
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DP_dateTGkt = new System.Windows.Forms.DateTimePicker();
            this.DP_dateTGbd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DP_butOK = new System.Windows.Forms.Button();
            this.DP_dateNS_KH = new System.Windows.Forms.DateTimePicker();
            this.DP_boxTenKH = new System.Windows.Forms.TextBox();
            this.DP_boxIDKH = new System.Windows.Forms.TextBox();
            this.DP_boxDC_KH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DP_panPT = new System.Windows.Forms.Panel();
            this.DP_dataPhong = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.DP_butXN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.DP_panPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DP_dataPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt phòng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DP_dateTGkt);
            this.panel1.Controls.Add(this.DP_dateTGbd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.DP_butOK);
            this.panel1.Controls.Add(this.DP_dateNS_KH);
            this.panel1.Controls.Add(this.DP_boxTenKH);
            this.panel1.Controls.Add(this.DP_boxIDKH);
            this.panel1.Controls.Add(this.DP_boxDC_KH);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 307);
            this.panel1.TabIndex = 1;
            // 
            // DP_dateTGkt
            // 
            this.DP_dateTGkt.Location = new System.Drawing.Point(4, 242);
            this.DP_dateTGkt.Name = "DP_dateTGkt";
            this.DP_dateTGkt.Size = new System.Drawing.Size(200, 20);
            this.DP_dateTGkt.TabIndex = 13;
            // 
            // DP_dateTGbd
            // 
            this.DP_dateTGbd.Location = new System.Drawing.Point(6, 203);
            this.DP_dateTGbd.Name = "DP_dateTGbd";
            this.DP_dateTGbd.Size = new System.Drawing.Size(200, 20);
            this.DP_dateTGbd.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Thời gian trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Thời gian bắt đàu thuê";
            // 
            // DP_butOK
            // 
            this.DP_butOK.Location = new System.Drawing.Point(75, 281);
            this.DP_butOK.Name = "DP_butOK";
            this.DP_butOK.Size = new System.Drawing.Size(75, 23);
            this.DP_butOK.TabIndex = 9;
            this.DP_butOK.Text = "OK";
            this.DP_butOK.UseVisualStyleBackColor = true;
            this.DP_butOK.Click += new System.EventHandler(this.DP_butOK_Click);
            // 
            // DP_dateNS_KH
            // 
            this.DP_dateNS_KH.Location = new System.Drawing.Point(6, 117);
            this.DP_dateNS_KH.Name = "DP_dateNS_KH";
            this.DP_dateNS_KH.Size = new System.Drawing.Size(200, 20);
            this.DP_dateNS_KH.TabIndex = 8;
            // 
            // DP_boxTenKH
            // 
            this.DP_boxTenKH.Location = new System.Drawing.Point(4, 40);
            this.DP_boxTenKH.Name = "DP_boxTenKH";
            this.DP_boxTenKH.Size = new System.Drawing.Size(209, 20);
            this.DP_boxTenKH.TabIndex = 7;
            // 
            // DP_boxIDKH
            // 
            this.DP_boxIDKH.Location = new System.Drawing.Point(4, 80);
            this.DP_boxIDKH.Name = "DP_boxIDKH";
            this.DP_boxIDKH.Size = new System.Drawing.Size(209, 20);
            this.DP_boxIDKH.TabIndex = 6;
            // 
            // DP_boxDC_KH
            // 
            this.DP_boxDC_KH.Location = new System.Drawing.Point(2, 159);
            this.DP_boxDC_KH.Name = "DP_boxDC_KH";
            this.DP_boxDC_KH.Size = new System.Drawing.Size(207, 20);
            this.DP_boxDC_KH.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Năm sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số CMND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // DP_panPT
            // 
            this.DP_panPT.Controls.Add(this.DP_dataPhong);
            this.DP_panPT.Controls.Add(this.label7);
            this.DP_panPT.Enabled = false;
            this.DP_panPT.Location = new System.Drawing.Point(248, 26);
            this.DP_panPT.Name = "DP_panPT";
            this.DP_panPT.Size = new System.Drawing.Size(316, 307);
            this.DP_panPT.TabIndex = 2;
            this.DP_panPT.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DP_dataPhong
            // 
            this.DP_dataPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DP_dataPhong.Location = new System.Drawing.Point(3, 24);
            this.DP_dataPhong.Name = "DP_dataPhong";
            this.DP_dataPhong.Size = new System.Drawing.Size(310, 280);
            this.DP_dataPhong.TabIndex = 1;
            this.DP_dataPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DP_dataPhong_CellContentClick);
            this.DP_dataPhong.Click += new System.EventHandler(this.DP_dataPhong_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(111, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Các phòng còn trống";
            // 
            // DP_butXN
            // 
            this.DP_butXN.Location = new System.Drawing.Point(229, 346);
            this.DP_butXN.Name = "DP_butXN";
            this.DP_butXN.Size = new System.Drawing.Size(75, 23);
            this.DP_butXN.TabIndex = 3;
            this.DP_butXN.Text = "Thuê!";
            this.DP_butXN.UseVisualStyleBackColor = true;
            this.DP_butXN.Click += new System.EventHandler(this.DP_butXN_Click);
            // 
            // DPform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 381);
            this.Controls.Add(this.DP_butXN);
            this.Controls.Add(this.DP_panPT);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DPform";
            this.Text = "DatPhong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DP_panPT.ResumeLayout(false);
            this.DP_panPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DP_dataPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DP_butOK;
        private System.Windows.Forms.DateTimePicker DP_dateNS_KH;
        private System.Windows.Forms.TextBox DP_boxTenKH;
        private System.Windows.Forms.TextBox DP_boxIDKH;
        private System.Windows.Forms.TextBox DP_boxDC_KH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel DP_panPT;
        private System.Windows.Forms.DataGridView DP_dataPhong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DP_dateTGkt;
        private System.Windows.Forms.DateTimePicker DP_dateTGbd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DP_butXN;
    }
}