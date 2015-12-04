namespace WindowsFormsApplication1
{
    partial class QLKS
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
            this.QLP = new System.Windows.Forms.TabControl();
            this.QLP_rented = new System.Windows.Forms.TabPage();
            this.QLP_rented_data = new System.Windows.Forms.DataGridView();
            this.QLP_free = new System.Windows.Forms.TabPage();
            this.QLP_free_data = new System.Windows.Forms.DataGridView();
            this.QLP_all = new System.Windows.Forms.TabPage();
            this.QLP_dataTC = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.QLP_TP_butOK = new System.Windows.Forms.Button();
            this.QLP_TP_boxID = new System.Windows.Forms.TextBox();
            this.QLP_TP_kq = new System.Windows.Forms.DataGridView();
            this.QLP_TP_pan = new System.Windows.Forms.Panel();
            this.QLP_TP_tgkt = new System.Windows.Forms.DateTimePicker();
            this.QLP_TP_tgbd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.QLP_radioTGthue = new System.Windows.Forms.RadioButton();
            this.QLP_radioSP = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QLKH = new System.Windows.Forms.TabControl();
            this.QLKH_DangThue = new System.Windows.Forms.TabPage();
            this.QLP_dataDang_DP = new System.Windows.Forms.DataGridView();
            this.QLKH_DaTra = new System.Windows.Forms.TabPage();
            this.QLKH_dataDa_dat = new System.Windows.Forms.DataGridView();
            this.QLKH_all = new System.Windows.Forms.TabPage();
            this.QLKH_dataTC = new System.Windows.Forms.DataGridView();
            this.QLKH_Tim = new System.Windows.Forms.TabPage();
            this.QLKH_Tim_butOK = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.QLKH_Tim_pan = new System.Windows.Forms.Panel();
            this.QLKH_Tim_tgkt = new System.Windows.Forms.DateTimePicker();
            this.QLKH_Tim_tgbd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.QLKH_Tim_radioTG = new System.Windows.Forms.RadioButton();
            this.QLKH_Tim_boxTen = new System.Windows.Forms.TextBox();
            this.QLKH_Tim_boxID = new System.Windows.Forms.TextBox();
            this.QLKH_Tim_radioTen = new System.Windows.Forms.RadioButton();
            this.QLKH_Tim_radioID = new System.Windows.Forms.RadioButton();
            this.ok_but = new System.Windows.Forms.Button();
            this.QLDP_butThemDP = new System.Windows.Forms.Button();
            this.QLP.SuspendLayout();
            this.QLP_rented.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLP_rented_data)).BeginInit();
            this.QLP_free.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLP_free_data)).BeginInit();
            this.QLP_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLP_dataTC)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLP_TP_kq)).BeginInit();
            this.QLP_TP_pan.SuspendLayout();
            this.QLKH.SuspendLayout();
            this.QLKH_DangThue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLP_dataDang_DP)).BeginInit();
            this.QLKH_DaTra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLKH_dataDa_dat)).BeginInit();
            this.QLKH_all.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLKH_dataTC)).BeginInit();
            this.QLKH_Tim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.QLKH_Tim_pan.SuspendLayout();
            this.SuspendLayout();
            // 
            // QLP
            // 
            this.QLP.Controls.Add(this.QLP_rented);
            this.QLP.Controls.Add(this.QLP_free);
            this.QLP.Controls.Add(this.QLP_all);
            this.QLP.Controls.Add(this.tabPage1);
            this.QLP.Location = new System.Drawing.Point(3, 45);
            this.QLP.Name = "QLP";
            this.QLP.SelectedIndex = 0;
            this.QLP.Size = new System.Drawing.Size(435, 328);
            this.QLP.TabIndex = 0;
            // 
            // QLP_rented
            // 
            this.QLP_rented.Controls.Add(this.QLP_rented_data);
            this.QLP_rented.Location = new System.Drawing.Point(4, 22);
            this.QLP_rented.Name = "QLP_rented";
            this.QLP_rented.Padding = new System.Windows.Forms.Padding(3);
            this.QLP_rented.Size = new System.Drawing.Size(427, 302);
            this.QLP_rented.TabIndex = 0;
            this.QLP_rented.Text = "Các phòng đang thuê";
            this.QLP_rented.UseVisualStyleBackColor = true;
            // 
            // QLP_rented_data
            // 
            this.QLP_rented_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QLP_rented_data.Location = new System.Drawing.Point(5, 6);
            this.QLP_rented_data.Name = "QLP_rented_data";
            this.QLP_rented_data.Size = new System.Drawing.Size(419, 290);
            this.QLP_rented_data.TabIndex = 0;
            this.QLP_rented_data.Click += new System.EventHandler(this.QLP_rented_data_Click);
            // 
            // QLP_free
            // 
            this.QLP_free.Controls.Add(this.QLP_free_data);
            this.QLP_free.Location = new System.Drawing.Point(4, 22);
            this.QLP_free.Name = "QLP_free";
            this.QLP_free.Padding = new System.Windows.Forms.Padding(3);
            this.QLP_free.Size = new System.Drawing.Size(427, 302);
            this.QLP_free.TabIndex = 1;
            this.QLP_free.Text = "Phòng trống";
            this.QLP_free.UseVisualStyleBackColor = true;
            // 
            // QLP_free_data
            // 
            this.QLP_free_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QLP_free_data.Location = new System.Drawing.Point(7, 7);
            this.QLP_free_data.Name = "QLP_free_data";
            this.QLP_free_data.Size = new System.Drawing.Size(404, 289);
            this.QLP_free_data.TabIndex = 0;
            this.QLP_free_data.Click += new System.EventHandler(this.QLP_free_data_Click);
            // 
            // QLP_all
            // 
            this.QLP_all.Controls.Add(this.QLP_dataTC);
            this.QLP_all.Location = new System.Drawing.Point(4, 22);
            this.QLP_all.Name = "QLP_all";
            this.QLP_all.Padding = new System.Windows.Forms.Padding(3);
            this.QLP_all.Size = new System.Drawing.Size(427, 302);
            this.QLP_all.TabIndex = 2;
            this.QLP_all.Text = "Tất cả";
            this.QLP_all.UseVisualStyleBackColor = true;
            // 
            // QLP_dataTC
            // 
            this.QLP_dataTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QLP_dataTC.Location = new System.Drawing.Point(6, 3);
            this.QLP_dataTC.Name = "QLP_dataTC";
            this.QLP_dataTC.Size = new System.Drawing.Size(415, 288);
            this.QLP_dataTC.TabIndex = 0;
            this.QLP_dataTC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.QLP_dataTC_CellContentClick);
            this.QLP_dataTC.Click += new System.EventHandler(this.QLP_dataTC_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.QLP_TP_butOK);
            this.tabPage1.Controls.Add(this.QLP_TP_boxID);
            this.tabPage1.Controls.Add(this.QLP_TP_kq);
            this.tabPage1.Controls.Add(this.QLP_TP_pan);
            this.tabPage1.Controls.Add(this.QLP_radioTGthue);
            this.tabPage1.Controls.Add(this.QLP_radioSP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 302);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Tìm Phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // QLP_TP_butOK
            // 
            this.QLP_TP_butOK.Location = new System.Drawing.Point(335, 100);
            this.QLP_TP_butOK.Name = "QLP_TP_butOK";
            this.QLP_TP_butOK.Size = new System.Drawing.Size(75, 23);
            this.QLP_TP_butOK.TabIndex = 5;
            this.QLP_TP_butOK.Text = "Tìm";
            this.QLP_TP_butOK.UseVisualStyleBackColor = true;
            this.QLP_TP_butOK.Click += new System.EventHandler(this.QLP_TP_butOK_Click);
            // 
            // QLP_TP_boxID
            // 
            this.QLP_TP_boxID.Enabled = false;
            this.QLP_TP_boxID.Location = new System.Drawing.Point(102, 7);
            this.QLP_TP_boxID.Name = "QLP_TP_boxID";
            this.QLP_TP_boxID.Size = new System.Drawing.Size(74, 20);
            this.QLP_TP_boxID.TabIndex = 4;
            // 
            // QLP_TP_kq
            // 
            this.QLP_TP_kq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QLP_TP_kq.Location = new System.Drawing.Point(7, 129);
            this.QLP_TP_kq.Name = "QLP_TP_kq";
            this.QLP_TP_kq.Size = new System.Drawing.Size(414, 166);
            this.QLP_TP_kq.TabIndex = 3;
            // 
            // QLP_TP_pan
            // 
            this.QLP_TP_pan.Controls.Add(this.QLP_TP_tgkt);
            this.QLP_TP_pan.Controls.Add(this.QLP_TP_tgbd);
            this.QLP_TP_pan.Controls.Add(this.label4);
            this.QLP_TP_pan.Controls.Add(this.label3);
            this.QLP_TP_pan.Enabled = false;
            this.QLP_TP_pan.Location = new System.Drawing.Point(102, 33);
            this.QLP_TP_pan.Name = "QLP_TP_pan";
            this.QLP_TP_pan.Size = new System.Drawing.Size(212, 90);
            this.QLP_TP_pan.TabIndex = 2;
            // 
            // QLP_TP_tgkt
            // 
            this.QLP_TP_tgkt.Location = new System.Drawing.Point(0, 60);
            this.QLP_TP_tgkt.Name = "QLP_TP_tgkt";
            this.QLP_TP_tgkt.Size = new System.Drawing.Size(200, 20);
            this.QLP_TP_tgkt.TabIndex = 3;
            // 
            // QLP_TP_tgbd
            // 
            this.QLP_TP_tgbd.Location = new System.Drawing.Point(0, 26);
            this.QLP_TP_tgbd.Name = "QLP_TP_tgbd";
            this.QLP_TP_tgbd.Size = new System.Drawing.Size(200, 20);
            this.QLP_TP_tgbd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thời gian trả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thời gian đặt";
            // 
            // QLP_radioTGthue
            // 
            this.QLP_radioTGthue.AutoSize = true;
            this.QLP_radioTGthue.Location = new System.Drawing.Point(7, 29);
            this.QLP_radioTGthue.Name = "QLP_radioTGthue";
            this.QLP_radioTGthue.Size = new System.Drawing.Size(93, 17);
            this.QLP_radioTGthue.TabIndex = 1;
            this.QLP_radioTGthue.TabStop = true;
            this.QLP_radioTGthue.Text = "Thời gian thuê";
            this.QLP_radioTGthue.UseVisualStyleBackColor = true;
            this.QLP_radioTGthue.CheckedChanged += new System.EventHandler(this.QLP_radioTGthue_CheckedChanged);
            // 
            // QLP_radioSP
            // 
            this.QLP_radioSP.AutoSize = true;
            this.QLP_radioSP.Location = new System.Drawing.Point(6, 6);
            this.QLP_radioSP.Name = "QLP_radioSP";
            this.QLP_radioSP.Size = new System.Drawing.Size(72, 17);
            this.QLP_radioSP.TabIndex = 0;
            this.QLP_radioSP.TabStop = true;
            this.QLP_radioSP.Text = "Số Phòng";
            this.QLP_radioSP.UseVisualStyleBackColor = true;
            this.QLP_radioSP.CheckedChanged += new System.EventHandler(this.QLP_radioSP_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(775, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(35, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Help?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quản lý khách hàng";
            // 
            // QLKH
            // 
            this.QLKH.Controls.Add(this.QLKH_DangThue);
            this.QLKH.Controls.Add(this.QLKH_DaTra);
            this.QLKH.Controls.Add(this.QLKH_all);
            this.QLKH.Controls.Add(this.QLKH_Tim);
            this.QLKH.Location = new System.Drawing.Point(444, 45);
            this.QLKH.Name = "QLKH";
            this.QLKH.SelectedIndex = 0;
            this.QLKH.Size = new System.Drawing.Size(376, 328);
            this.QLKH.TabIndex = 4;
            // 
            // QLKH_DangThue
            // 
            this.QLKH_DangThue.Controls.Add(this.QLP_dataDang_DP);
            this.QLKH_DangThue.Location = new System.Drawing.Point(4, 22);
            this.QLKH_DangThue.Name = "QLKH_DangThue";
            this.QLKH_DangThue.Padding = new System.Windows.Forms.Padding(3);
            this.QLKH_DangThue.Size = new System.Drawing.Size(368, 302);
            this.QLKH_DangThue.TabIndex = 0;
            this.QLKH_DangThue.Text = "Khách hàng đã đặt phòng";
            this.QLKH_DangThue.UseVisualStyleBackColor = true;
            // 
            // QLP_dataDang_DP
            // 
            this.QLP_dataDang_DP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QLP_dataDang_DP.Location = new System.Drawing.Point(4, 7);
            this.QLP_dataDang_DP.Name = "QLP_dataDang_DP";
            this.QLP_dataDang_DP.Size = new System.Drawing.Size(358, 288);
            this.QLP_dataDang_DP.TabIndex = 0;
            this.QLP_dataDang_DP.Click += new System.EventHandler(this.QLP_dataDang_DP_Click);
            // 
            // QLKH_DaTra
            // 
            this.QLKH_DaTra.Controls.Add(this.QLKH_dataDa_dat);
            this.QLKH_DaTra.Location = new System.Drawing.Point(4, 22);
            this.QLKH_DaTra.Name = "QLKH_DaTra";
            this.QLKH_DaTra.Padding = new System.Windows.Forms.Padding(3);
            this.QLKH_DaTra.Size = new System.Drawing.Size(368, 302);
            this.QLKH_DaTra.TabIndex = 1;
            this.QLKH_DaTra.Text = "Khách hàng đang thuê";
            this.QLKH_DaTra.UseVisualStyleBackColor = true;
            this.QLKH_DaTra.Click += new System.EventHandler(this.QLKH_DaTra_Click);
            // 
            // QLKH_dataDa_dat
            // 
            this.QLKH_dataDa_dat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QLKH_dataDa_dat.Location = new System.Drawing.Point(7, 7);
            this.QLKH_dataDa_dat.Name = "QLKH_dataDa_dat";
            this.QLKH_dataDa_dat.Size = new System.Drawing.Size(355, 288);
            this.QLKH_dataDa_dat.TabIndex = 1;
            this.QLKH_dataDa_dat.Click += new System.EventHandler(this.QLKH_dataDa_dat_Click);
            // 
            // QLKH_all
            // 
            this.QLKH_all.Controls.Add(this.QLKH_dataTC);
            this.QLKH_all.Location = new System.Drawing.Point(4, 22);
            this.QLKH_all.Name = "QLKH_all";
            this.QLKH_all.Padding = new System.Windows.Forms.Padding(3);
            this.QLKH_all.Size = new System.Drawing.Size(368, 302);
            this.QLKH_all.TabIndex = 2;
            this.QLKH_all.Text = "Tất cả";
            this.QLKH_all.UseVisualStyleBackColor = true;
            // 
            // QLKH_dataTC
            // 
            this.QLKH_dataTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QLKH_dataTC.Location = new System.Drawing.Point(7, 7);
            this.QLKH_dataTC.Name = "QLKH_dataTC";
            this.QLKH_dataTC.Size = new System.Drawing.Size(355, 288);
            this.QLKH_dataTC.TabIndex = 1;
            this.QLKH_dataTC.Click += new System.EventHandler(this.QLKH_dataTC_Click);
            // 
            // QLKH_Tim
            // 
            this.QLKH_Tim.Controls.Add(this.QLKH_Tim_butOK);
            this.QLKH_Tim.Controls.Add(this.dataGridView1);
            this.QLKH_Tim.Controls.Add(this.QLKH_Tim_pan);
            this.QLKH_Tim.Controls.Add(this.QLKH_Tim_radioTG);
            this.QLKH_Tim.Controls.Add(this.QLKH_Tim_boxTen);
            this.QLKH_Tim.Controls.Add(this.QLKH_Tim_boxID);
            this.QLKH_Tim.Controls.Add(this.QLKH_Tim_radioTen);
            this.QLKH_Tim.Controls.Add(this.QLKH_Tim_radioID);
            this.QLKH_Tim.Location = new System.Drawing.Point(4, 22);
            this.QLKH_Tim.Name = "QLKH_Tim";
            this.QLKH_Tim.Padding = new System.Windows.Forms.Padding(3);
            this.QLKH_Tim.Size = new System.Drawing.Size(368, 302);
            this.QLKH_Tim.TabIndex = 3;
            this.QLKH_Tim.Text = "Tìm khách hàng";
            this.QLKH_Tim.UseVisualStyleBackColor = true;
            // 
            // QLKH_Tim_butOK
            // 
            this.QLKH_Tim_butOK.Location = new System.Drawing.Point(10, 233);
            this.QLKH_Tim_butOK.Name = "QLKH_Tim_butOK";
            this.QLKH_Tim_butOK.Size = new System.Drawing.Size(75, 23);
            this.QLKH_Tim_butOK.TabIndex = 8;
            this.QLKH_Tim_butOK.Text = "Tìm";
            this.QLKH_Tim_butOK.UseVisualStyleBackColor = true;
            this.QLKH_Tim_butOK.Click += new System.EventHandler(this.QLKH_Tim_butOK_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 288);
            this.dataGridView1.TabIndex = 7;
            // 
            // QLKH_Tim_pan
            // 
            this.QLKH_Tim_pan.Controls.Add(this.QLKH_Tim_tgkt);
            this.QLKH_Tim_pan.Controls.Add(this.QLKH_Tim_tgbd);
            this.QLKH_Tim_pan.Controls.Add(this.label5);
            this.QLKH_Tim_pan.Controls.Add(this.label6);
            this.QLKH_Tim_pan.Enabled = false;
            this.QLKH_Tim_pan.Location = new System.Drawing.Point(7, 125);
            this.QLKH_Tim_pan.Name = "QLKH_Tim_pan";
            this.QLKH_Tim_pan.Size = new System.Drawing.Size(100, 90);
            this.QLKH_Tim_pan.TabIndex = 6;
            // 
            // QLKH_Tim_tgkt
            // 
            this.QLKH_Tim_tgkt.Location = new System.Drawing.Point(0, 60);
            this.QLKH_Tim_tgkt.Name = "QLKH_Tim_tgkt";
            this.QLKH_Tim_tgkt.Size = new System.Drawing.Size(93, 20);
            this.QLKH_Tim_tgkt.TabIndex = 3;
            // 
            // QLKH_Tim_tgbd
            // 
            this.QLKH_Tim_tgbd.Location = new System.Drawing.Point(3, 20);
            this.QLKH_Tim_tgbd.Name = "QLKH_Tim_tgbd";
            this.QLKH_Tim_tgbd.Size = new System.Drawing.Size(90, 20);
            this.QLKH_Tim_tgbd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thời gian trả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thời gian đặt";
            // 
            // QLKH_Tim_radioTG
            // 
            this.QLKH_Tim_radioTG.AutoSize = true;
            this.QLKH_Tim_radioTG.Location = new System.Drawing.Point(7, 102);
            this.QLKH_Tim_radioTG.Name = "QLKH_Tim_radioTG";
            this.QLKH_Tim_radioTG.Size = new System.Drawing.Size(107, 17);
            this.QLKH_Tim_radioTG.TabIndex = 5;
            this.QLKH_Tim_radioTG.TabStop = true;
            this.QLKH_Tim_radioTG.Text = "Tìm thep t/g thuê";
            this.QLKH_Tim_radioTG.UseVisualStyleBackColor = true;
            this.QLKH_Tim_radioTG.CheckedChanged += new System.EventHandler(this.QLKH_Tim_radioTG_CheckedChanged);
            // 
            // QLKH_Tim_boxTen
            // 
            this.QLKH_Tim_boxTen.Location = new System.Drawing.Point(7, 72);
            this.QLKH_Tim_boxTen.Name = "QLKH_Tim_boxTen";
            this.QLKH_Tim_boxTen.Size = new System.Drawing.Size(100, 20);
            this.QLKH_Tim_boxTen.TabIndex = 4;
            // 
            // QLKH_Tim_boxID
            // 
            this.QLKH_Tim_boxID.Enabled = false;
            this.QLKH_Tim_boxID.Location = new System.Drawing.Point(7, 29);
            this.QLKH_Tim_boxID.Name = "QLKH_Tim_boxID";
            this.QLKH_Tim_boxID.Size = new System.Drawing.Size(100, 20);
            this.QLKH_Tim_boxID.TabIndex = 3;
            // 
            // QLKH_Tim_radioTen
            // 
            this.QLKH_Tim_radioTen.AutoSize = true;
            this.QLKH_Tim_radioTen.Location = new System.Drawing.Point(7, 51);
            this.QLKH_Tim_radioTen.Name = "QLKH_Tim_radioTen";
            this.QLKH_Tim_radioTen.Size = new System.Drawing.Size(84, 17);
            this.QLKH_Tim_radioTen.TabIndex = 1;
            this.QLKH_Tim_radioTen.TabStop = true;
            this.QLKH_Tim_radioTen.Text = "Tìm theo tên";
            this.QLKH_Tim_radioTen.UseVisualStyleBackColor = true;
            this.QLKH_Tim_radioTen.CheckedChanged += new System.EventHandler(this.QLKH_Tim_radioTen_CheckedChanged);
            // 
            // QLKH_Tim_radioID
            // 
            this.QLKH_Tim_radioID.AutoSize = true;
            this.QLKH_Tim_radioID.Location = new System.Drawing.Point(7, 7);
            this.QLKH_Tim_radioID.Name = "QLKH_Tim_radioID";
            this.QLKH_Tim_radioID.Size = new System.Drawing.Size(101, 17);
            this.QLKH_Tim_radioID.TabIndex = 0;
            this.QLKH_Tim_radioID.TabStop = true;
            this.QLKH_Tim_radioID.Text = "Tìm theo CMND";
            this.QLKH_Tim_radioID.UseVisualStyleBackColor = true;
            this.QLKH_Tim_radioID.CheckedChanged += new System.EventHandler(this.QLKH_Tim_radioID_CheckedChanged);
            // 
            // ok_but
            // 
            this.ok_but.Location = new System.Drawing.Point(745, 375);
            this.ok_but.Name = "ok_but";
            this.ok_but.Size = new System.Drawing.Size(75, 23);
            this.ok_but.TabIndex = 5;
            this.ok_but.Text = "Exit";
            this.ok_but.UseVisualStyleBackColor = true;
            this.ok_but.Click += new System.EventHandler(this.ok_but_Click);
            // 
            // QLDP_butThemDP
            // 
            this.QLDP_butThemDP.Location = new System.Drawing.Point(10, 374);
            this.QLDP_butThemDP.Name = "QLDP_butThemDP";
            this.QLDP_butThemDP.Size = new System.Drawing.Size(75, 23);
            this.QLDP_butThemDP.TabIndex = 6;
            this.QLDP_butThemDP.Text = "Đặt Phòng";
            this.QLDP_butThemDP.UseVisualStyleBackColor = true;
            this.QLDP_butThemDP.Click += new System.EventHandler(this.QLDP_butThemDP_Click);
            // 
            // QLKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 402);
            this.Controls.Add(this.QLDP_butThemDP);
            this.Controls.Add(this.ok_but);
            this.Controls.Add(this.QLKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.QLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLKS";
            this.Text = "QLKS";
            this.QLP.ResumeLayout(false);
            this.QLP_rented.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLP_rented_data)).EndInit();
            this.QLP_free.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLP_free_data)).EndInit();
            this.QLP_all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLP_dataTC)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QLP_TP_kq)).EndInit();
            this.QLP_TP_pan.ResumeLayout(false);
            this.QLP_TP_pan.PerformLayout();
            this.QLKH.ResumeLayout(false);
            this.QLKH_DangThue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLP_dataDang_DP)).EndInit();
            this.QLKH_DaTra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLKH_dataDa_dat)).EndInit();
            this.QLKH_all.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QLKH_dataTC)).EndInit();
            this.QLKH_Tim.ResumeLayout(false);
            this.QLKH_Tim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.QLKH_Tim_pan.ResumeLayout(false);
            this.QLKH_Tim_pan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl QLP;
        private System.Windows.Forms.TabPage QLP_rented;
        private System.Windows.Forms.TabPage QLP_free;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView QLP_rented_data;
        private System.Windows.Forms.DataGridView QLP_free_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl QLKH;
        private System.Windows.Forms.TabPage QLKH_DangThue;
        private System.Windows.Forms.TabPage QLKH_DaTra;
        private System.Windows.Forms.TabPage QLP_all;
        private System.Windows.Forms.TabPage QLKH_all;
        private System.Windows.Forms.Button ok_but;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox QLP_TP_boxID;
        private System.Windows.Forms.DataGridView QLP_TP_kq;
        private System.Windows.Forms.Panel QLP_TP_pan;
        private System.Windows.Forms.DateTimePicker QLP_TP_tgkt;
        private System.Windows.Forms.DateTimePicker QLP_TP_tgbd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton QLP_radioTGthue;
        private System.Windows.Forms.RadioButton QLP_radioSP;
        private System.Windows.Forms.Button QLP_TP_butOK;
        private System.Windows.Forms.TabPage QLKH_Tim;
        private System.Windows.Forms.Button QLKH_Tim_butOK;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel QLKH_Tim_pan;
        private System.Windows.Forms.DateTimePicker QLKH_Tim_tgkt;
        private System.Windows.Forms.DateTimePicker QLKH_Tim_tgbd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton QLKH_Tim_radioTG;
        private System.Windows.Forms.TextBox QLKH_Tim_boxTen;
        private System.Windows.Forms.TextBox QLKH_Tim_boxID;
        private System.Windows.Forms.RadioButton QLKH_Tim_radioTen;
        private System.Windows.Forms.RadioButton QLKH_Tim_radioID;
        private System.Windows.Forms.DataGridView QLP_dataTC;
        private System.Windows.Forms.DataGridView QLP_dataDang_DP;
        private System.Windows.Forms.DataGridView QLKH_dataDa_dat;
        private System.Windows.Forms.DataGridView QLKH_dataTC;
        private System.Windows.Forms.Button QLDP_butThemDP;
    }
}