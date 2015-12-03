using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class QuanLy : Form
    {
        
        public QuanLy()
        {
            InitializeComponent();
          
        }
        Login fm1 = new Login();
        public string user = "";
        
        public delegate void delPassData(TextBox text);
        public void funData(TextBox txtForm1)
        {
            user = txtForm1.Text;
        }
        private void QLH_TK_checkMH_CheckedChanged(object sender, EventArgs e)
        {
            QLH_TK_boxMA.Enabled = !QLH_TK_boxMA.Enabled;
        }

        private void QLH_TK_butTim_Click(object sender, EventArgs e)
        {
            //truy van csdl theo các trường tìm kiếm đã chọn
            if (raXuat.Checked == true)
            {
                if (QLH_TK_boxMA.Text != "")
                {
                    QLK_dataHang.DataSource = connect.Tim_HangXuat(QLH_TK_boxMA.Text);
                }
                else
                    MessageBox.Show("Nhap ma hang");
            }
            else
            {
                if (QLH_TK_boxMA.Text != "")
                {
                    QLK_dataHang.DataSource = connect.Tim_HangNhap(QLH_TK_boxMA.Text);
                }
                else
                    MessageBox.Show("Nhap ma hang");
            }
        }

        private void QLNV_linkTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ket csdl đổ dữ liệu vào bảng
            if (QLNV_tim_radioTen.Checked)
            {
                QLNV_dataTim.DataSource = connect.TK_NV_Ten(QLNV_Tim_boxHTen.Text);
            }
            if (QLNV_Tim_radioID.Checked)
            {
                QLNV_dataTim.DataSource = connect.TK_NV_Ma(QLNV_tim_boxID.Text);
            }

        }

        private void linkTimKH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (QLKH_TimTen.Checked)
            {
                dataGridView1.DataSource = connect.TK_KH_Ten(QLKH_Tim_boxTen.Text);
            }
            if (QLKH_TimID.Checked)
            {
                dataGridView1.DataSource = connect.TK_KH_Ma(QLKH_Tim_boxID.Text);
            }
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HuongDan formHD = new HuongDan();
            formHD.ShowDialog();
        }

        private void btBan_Click(object sender, EventArgs e)
        {
            bool kt = false;
            if (bh_QL_ID.Text != "" && bh_boxTenHang.Text != "")
            {
                kt = connect.BanHang(bh_boxTenHang.Text, Convert.ToInt16(bh_QL_ID.Text));
                
                if (kt)
                    MessageBox.Show("Ban thanh cong");
                else
                    MessageBox.Show("Ban that bai");
            }
            else
                MessageBox.Show("Nhap ten hang ban va so luong");
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            User nv = new User();
            nv = connect.LoadNV(user);
            labNhanVien.Text = labNhanVien.Text + nv.HoTen;
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radHangChay.Checked) 
            {
                TKHH_dataTK.DataSource = connect.TK_HangChay();
            }
            if (radHangCham.Checked)
            {
                TKHH_dataTK.DataSource = connect.TK_HangCham();
            }
            if (radHangMoi.Checked)
            {
                TKHH_dataTK.DataSource = connect.TK_HangMoi(DateTime.Now.AddDays(-15));
            }
            if (raHangBanGan.Checked)
            {
                   TKHH_dataTK.DataSource = connect.TK_HangGanDay();
            }
        }

        private void QLNV_butOK_Click(object sender, EventArgs e)
        {
            bool kt = false;
            if (QLNV_boxID.Text != "" && QLNV_boxBP.Text != "" && QLNV_boxGT.Text != "" && QLNV_boxLuong.Text != "" && QLNV_boxTen.Text != "")
            {
                kt = connect.Them_NV(QLNV_boxID.Text, QLNV_boxTen.Text, Convert.ToInt32(QLNV_boxLuong.Text), QLNV_boxBP.Text, QLNV_boxGT.Text, QLNV_dateNS.Value);
                if (kt)
                    MessageBox.Show("Them nhan vien thanh cong");
                else
                    MessageBox.Show("Them nhan vien that bai");
            }
            else
                MessageBox.Show("Nhap du thong tin");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool kt = false;
            if (QLNV_boxID.Text != "" && QLNV_boxBP.Text != "" && QLNV_boxGT.Text != "" && QLNV_boxLuong.Text != "" && QLNV_boxTen.Text != "")
            {
                kt = connect.Xoa_NV(QLNV_boxID.Text);
                if (kt)
                    MessageBox.Show("Xoa nhan vien thanh cong");
                else
                    MessageBox.Show("Xoa nhan vien that bai");
            }
            else
                MessageBox.Show("Nhap du thong tin");
        }

        private void QLKH_TimID_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool kt = false;
            if (QLNV_boxID.Text != "" && QLNV_boxBP.Text != "" && QLNV_boxGT.Text != "" && QLNV_boxLuong.Text != "" && QLNV_boxTen.Text != "")
            {
                kt = connect.Sua_NV(QLNV_boxID.Text, QLNV_boxTen.Text, Convert.ToInt32(QLNV_boxLuong.Text), QLNV_boxBP.Text, QLNV_boxGT.Text, QLNV_dateNS.Value);
                if (kt)
                    MessageBox.Show("Sua nhan vien thanh cong");
                else
                    MessageBox.Show("Sua nhan vien that bai");
            }
            else
                MessageBox.Show("Nhap du thong tin");
        }

        private void QLKH_but_OK_Click(object sender, EventArgs e)
        {
            if (txtCmnd.Text != "" && txtdc.Text != "" && txtdt.Text != "" && txtnct.Text != "" && txtten.Text != "")
            {
                KhachHang k = new KhachHang();
                k.CMND = txtCmnd.Text;
                k.HoTen = txtten.Text;
                k.SDT = txtdt.Text;
                k.DiaChi = txtdc.Text;
                k.NoiLamViec = txtnct.Text;
                k.NS = QLKH_dateNS.Value;
                bool kt = connect.Them_KH(k);
                if (kt)
                    MessageBox.Show("Them khach hang thanh cong");
                else
                    MessageBox.Show("Them khach hang that bai");
            }
            else
                MessageBox.Show("Nhap du thong tin");
        }

        private void QLKH_but_del_Click(object sender, EventArgs e)
        {
            if (txtCmnd.Text != "" && txtdc.Text != "" && txtdt.Text != "" && txtnct.Text != "" && txtten.Text != "")
            {
                bool kt = connect.Xoa_KH(txtCmnd.Text);
                if (kt)
                    MessageBox.Show("Xoa khach hang thanh cong");
                else
                    MessageBox.Show("Xoa khach hang that bai");
            }
            else
                MessageBox.Show("Nhap du thong tin");
        }

        private void QLNV_dataTim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bh_QL_ID_TextChanged(object sender, EventArgs e)
        {
            int gia = connect.LoadGia(bh_boxTenHang.Text);
            labGia.Text = gia.ToString();
            LabTongTien.Text = (gia * Convert.ToInt32(bh_QL_ID.Text)).ToString();
        }
        
    }
}
