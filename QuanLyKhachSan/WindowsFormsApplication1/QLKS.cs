using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class QLKS : Form
    {
        public QLKS()
        {
            InitializeComponent();
            //Load từ csdl vào 2 datagridview, thêm 1 cột là button đê click vào sửa hàng tương ứng trên csdl
        }

        private void ok_but_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLP_radioSP_CheckedChanged(object sender, EventArgs e)
        {
            QLP_TP_boxID.Enabled = !QLP_TP_boxID.Enabled;
        }

        private void QLP_radioTGthue_CheckedChanged(object sender, EventArgs e)
        {
            QLP_TP_boxID.Enabled = !QLP_TP_boxID.Enabled;
        }

        private void QLP_TP_butOK_Click(object sender, EventArgs e)
        {
            //Trả kq ra bảng theo loại tìm kiếm đã chọn
            if (QLP_radioSP.Checked)
            {
                QLP_TP_boxID.Enabled = true;
                QLP_TP_pan.Enabled = false;
                if (QLP_TP_boxID.Text.Trim() != "")
                    QLP_TP_kq.DataSource = connect.TimPhong(QLP_TP_boxID.Text);
                else
                    MessageBox.Show("Nhap so phong can tim");
            }
            else
                if (QLP_radioTGthue.Checked)
                {
                    QLP_TP_pan.Enabled = true;
                    QLP_TP_boxID.Enabled = false;
                    if (QLP_TP_tgbd.Value < QLP_TP_tgkt.Value)
                    {
                        QLP_TP_kq.DataSource = connect.TimPhongTG(QLP_TP_tgbd.Value, QLP_TP_tgkt.Value);
                    }
                    else
                        MessageBox.Show("Thoi gian bat dau nho hon thoi gian ket thuc");
                }
                else
                {
                    MessageBox.Show("Chưa chọn và điền đủ thông tin!");
                    return;
                }
        }

        private void QLKH_Tim_radioID_CheckedChanged(object sender, EventArgs e)
        {
            QLKH_Tim_boxID.Enabled = true;
        }

        private void QLKH_Tim_radioTen_CheckedChanged(object sender, EventArgs e)
        {
            QLKH_Tim_boxTen.Enabled = !QLKH_Tim_boxTen.Enabled;
        }

        private void QLKH_Tim_radioTG_CheckedChanged(object sender, EventArgs e)
        {
            QLKH_Tim_pan.Enabled = !QLKH_Tim_pan.Enabled;
        }

        private void QLKH_Tim_butOK_Click(object sender, EventArgs e)
        {
            //Tìm theo loại đã chọn, đổ vào csdl
            if (QLKH_Tim_radioID.Checked)
            {
                QLKH_Tim_boxTen.Enabled = false;
                QLKH_Tim_boxID.Enabled = true;
                QLKH_Tim_pan.Enabled = false;
                if (QLKH_Tim_boxID.Text.Trim() != "")
                    dataGridView1.DataSource = connect.TimKH_CMND(QLKH_Tim_boxID.Text);
                else
                    MessageBox.Show("Nhap CMND khach hang");
            }
            if (QLKH_Tim_radioTen.Checked)
            {
                QLKH_Tim_boxTen.Enabled = true;
                QLKH_Tim_boxID.Enabled = false;
                QLKH_Tim_pan.Enabled = false;
                if (QLKH_Tim_boxTen.Text.Trim() != "")
                    dataGridView1.DataSource = connect.TimKH_Ten(QLKH_Tim_boxTen.Text);
                else
                    MessageBox.Show("Nhap ten khach hang");
            }
            if (QLKH_Tim_radioTG.Checked)
            {
                QLKH_Tim_boxTen.Enabled = false;
                QLKH_Tim_boxID.Enabled = false;
                QLKH_Tim_pan.Enabled = true;
                if (QLKH_Tim_tgbd.Value<QLKH_Tim_tgkt.Value)
                    dataGridView1.DataSource = connect.TimKH_TG(QLKH_Tim_tgbd.Value , QLKH_Tim_tgkt.Value);
                else
                    MessageBox.Show("Nhap thoi gian bat dau nho hon thoi gian ket thuc");
            }
            
        }

        private void QLDP_butThemDP_Click(object sender, EventArgs e)
        {
            DPform formDP = new DPform();
            formDP.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HuongDan formHD = new HuongDan();
            formHD.ShowDialog();
        }

        private void QLP_dataTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void QLP_dataTC_Click(object sender, EventArgs e)
        {
            QLP_dataTC.DataSource = connect.LoadFullPhong();
        }

        private void QLP_rented_data_Click(object sender, EventArgs e)
        {
            QLP_rented_data.DataSource = connect.LoadPhongSD();
        }

        private void QLP_free_data_Click(object sender, EventArgs e)
        {
            QLP_free_data.DataSource = connect.LoadPhongCSD();
        }

        private void QLKH_DaTra_Click(object sender, EventArgs e)
        {

        }

        private void QLKH_dataTC_Click(object sender, EventArgs e)
        {
            QLKH_dataTC.DataSource = connect.LoadFullKH();
        }

        private void QLKH_dataDa_dat_Click(object sender, EventArgs e)
        {
            QLKH_dataDa_dat.DataSource = connect.Load_KHDT(Convert.ToDateTime(DateTime.Now));
        }

        private void QLP_dataDang_DP_Click(object sender, EventArgs e)
        {
            QLP_dataDang_DP.DataSource = connect.Load_KHDaT(Convert.ToDateTime(DateTime.Now));
        }

    }
}
