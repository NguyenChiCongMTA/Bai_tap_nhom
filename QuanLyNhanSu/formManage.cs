using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class formManage : Form
    {
        public formManage()
        {
            InitializeComponent();
        }

        private void tabTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void butInsert_Click(object sender, EventArgs e)
        {
            classNV nv = new classNV();
            nv.hoten = in_boxName.Text;
            nv.ns = in_boxNS.Value;
            nv.quequan = in_boxQq.Text;
            nv.donvi = in_boxDV.Text;
            nv.hesoluong = int.Parse(in_boxBL.Text);
            nv.socmnd = in_boxCMND.Text;
            nv.sodienthoai = in_BoxDT.Text;
            string mess = connect.insert(nv) ? "Them thanh cong " : "Them that bai";
            MessageBox.Show(mess);
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            string mess = connect.Delete(xCMND.Text) ? "Xoa thanh cong " : "Xoa that bai";
            MessageBox.Show(mess);
        }

        private void sua_butTim_Click(object sender, EventArgs e)
        {
            dataGridView_sua.DataSource = connect.LoadData(sua_boxID.Text.Trim());
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            classNV nv = new classNV();
            nv.hoten = sHoten.Text;
            nv.ns = sNgaysinh.Value;
            nv.quequan = sQuequan.Text;
            nv.donvi = sDonvi.Text;
            nv.hesoluong = int.Parse(sBacluong.Text);
            nv.socmnd = sCMND.Text;
            nv.sodienthoai = sDienthoai.Text;
            string mess = connect.edit(nv,sCMND.Text) ? "Sua thanh cong " : "Sua that bai";
            MessageBox.Show(mess);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Load_Text(object sender, PaintEventArgs e)
        {
 
        }

        private void in_boxBL_TextChanged(object sender, EventArgs e)
        {

        }

        private void xoa_butTim_Click(object sender, EventArgs e)
        {
            dataGridView_xoa.DataSource = connect.LoadData(xoa_boxID.Text.Trim());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked=true)
                dataGridView1.DataSource = connect.LoadData(txtFind.Text.Trim());
            else
                dataGridView1.DataSource = connect.Find(txtFind.Text.Trim());
        }

        private void formManage_FormClosed(object sender, FormClosedEventArgs e)
        {
                
        }

        private void dataGridView_sua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sHoten.Text = dataGridView_sua.Rows[e.RowIndex].Cells[0].Value.ToString();
            sQuequan.Text = dataGridView_sua.Rows[e.RowIndex].Cells[2].Value.ToString();
            sNgaysinh.Value = Convert.ToDateTime(dataGridView_sua.Rows[e.RowIndex].Cells[1].Value.ToString());
            sBacluong.Text = dataGridView_sua.Rows[e.RowIndex].Cells[3].Value.ToString();
            sDonvi.Text = dataGridView_sua.Rows[e.RowIndex].Cells[4].Value.ToString();
            sDienthoai.Text = dataGridView_sua.Rows[e.RowIndex].Cells[5].Value.ToString();
            sCMND.Text = dataGridView_sua.Rows[e.RowIndex].Cells[6].Value.ToString();
         }

        private void dataGridView_xoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            xHoten.Text = dataGridView_xoa.Rows[e.RowIndex].Cells[0].Value.ToString();
            xQuequan.Text = dataGridView_xoa.Rows[e.RowIndex].Cells[2].Value.ToString();
            xNgaysinh.Value = Convert.ToDateTime(dataGridView_xoa.Rows[e.RowIndex].Cells[1].Value.ToString());
            xBacluong.Text = dataGridView_xoa.Rows[e.RowIndex].Cells[3].Value.ToString();
            xDonvi.Text = dataGridView_xoa.Rows[e.RowIndex].Cells[4].Value.ToString();
            xDienthoai.Text = dataGridView_xoa.Rows[e.RowIndex].Cells[5].Value.ToString();
            xCMND.Text = dataGridView_xoa.Rows[e.RowIndex].Cells[6].Value.ToString();
            panel3.Enabled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HuongDanForm frm = new HuongDanForm();
            frm.ShowDialog();
            frm.Close();
            frm.Dispose();
        }
    }
}
