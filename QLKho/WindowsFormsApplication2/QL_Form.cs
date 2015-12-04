using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class QL_Form : Form
    {
        public QL_Form()
        {
            InitializeComponent();
        }

        private void tab_QLN_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = connect.LoadLoaiHang();
        }
        public string Ma="";
        Hang s=new Hang();
        private void button1_Click(object sender, EventArgs e)
        {
            //string loaihang = QLN_listLoai.Items.
            //Cap nhat vao csdl
            bool kt=false;
            if (QLN_TenHang.Text != "" && QLN_Nguon.Text != "" && QLN_SL.Text != "" && Ma != "")
            {
                s.Ten = QLN_TenHang.Text;
                s.nguon = QLN_Nguon.Text;
                s.sl = Convert.ToInt16(QLN_SL.Text);
                s.Loai = Ma;
                kt = connect.NhapHang(s);
                kt = connect.PhieuNhap(s.Ten, s.sl, QLN_date.Value);
                if (kt) MessageBox.Show("Nhap thanh cong");
                else MessageBox.Show("Nhap that bai");
            }
            else
                MessageBox.Show("Nhap du thong tin va chon loai hang");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //cập nhật csdl với thông tin xuất hàng ở các box bên phải
            bool kt = false;
            if (SoLuong.Text != "" && NoiXuat.Text != "")
            {
                kt = connect.XuatHang(QLX_boxID.Text, Convert.ToInt16(SoLuong.Text));
                kt = connect.PhieuXuat(QLX_boxID.Text, Convert.ToInt16(SoLuong.Text), NgayXuat.Value, NoiXuat.Text);
                if (kt) MessageBox.Show("Xuat hang thanh cong");
                else
                    MessageBox.Show("Xuat hang that bai");
            }

        }

        private void QLX_linkTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //tim trong csdl hàng có id tương ứng, đổ vảo các box
            if (QLX_boxID.Text != "")
                dataGridView2.DataSource = connect.TimHang(QLX_boxID.Text);
            else
                MessageBox.Show("Nhap ma can tim");
        }

        private void linkHD_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //show form chứa html hướng dẫn lên
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ten=dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            Ma = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            MessageBox.Show("LoaiHang: " + ten);
        }


    }
}
