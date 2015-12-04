using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_HS_GV.Class;
namespace QL_HS_GV
{
    public partial class ThongTin : Form
    {
        public ThongTin()
        {
            InitializeComponent();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            textMa.Clear();
            textLop.Clear();
            textTen.Clear();
            textKhoa.Clear();
            textGT.Clear();
            textNS2.Visible = true;
            textNS.Visible = false;
            textNS2.Clear();
            bntThem.Visible = true;
            bntHuy.Visible = bntLuu.Visible = true;
            bntSua.Visible = bntXoa.Visible = false;
            textNS2.Visible = false;
            textNS.Visible = true;
            bntThem.Enabled = false;
        }
        string id = null;
        private void dataHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textNS2.Visible = false;
            textNS.Visible = true;
            if (e.RowIndex >= dataHS.Rows.Count) return;
            textMa.Text = id = dataHS.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            textTen.Text = dataHS.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            textGT.Text = dataHS.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            textNS.Value =DateTime.Parse(dataHS.Rows[e.RowIndex].Cells[3].Value.ToString());
            textLop.Text = dataHS.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            textKhoa.Text = dataHS.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
        }

        private void ThongTin_Load(object sender, EventArgs e)
        {
            dataHS.DataSource = new Connection().LoadData();
            dataGV.DataSource = new Connection2().LoadData();
        }

        private void bntLuu_Click(object sender, EventArgs e)
        {
            if (bntThem.Visible == true)
            {
                if (textTen.Text.Trim() == "" || textGT.Text.Trim() == "" || textNS.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập dữ liệu vào khung thông tin");
                }
                else
                {
                    Hocsinh hs = new Hocsinh();
                    hs.Name1 = textTen.Text.Trim();
                    hs.GT1 = textGT.Text.Trim();
                    hs.NS1 = textNS.Value;
                    textNS2.Focus();
                    hs.Lop1 = textLop.Text.Trim();
                    hs.Khoa1 = textKhoa.Text.Trim();
                    bool ktra = new Connection().ThemHS(hs);
                    if (ktra == true)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công");
                        dataHS.DataSource = new Connection().LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm được học sinh mới. Hãy thử lại");
                    }
                }
            }
            if (bntSua.Visible == true)
            {
                Hocsinh hs = new Hocsinh();
                hs.ID1 = textMa.Text.Trim();
                hs.Name1 = textTen.Text.Trim();
                hs.GT1 = textGT.Text.Trim();
                hs.NS1 = textNS.Value;
                hs.Lop1 = textLop.Text.Trim();
                hs.Khoa1 = textKhoa.Text.Trim();
                bool ktra = new Connection().SuaHS(hs);
                if (ktra == true)
                {
                    MessageBox.Show("Sửa dữ liệu thành công");
                    dataHS.DataSource = new Connection().LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể Sửa được học sinh mới. Hãy thử lại");
                }
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            bntLuu.Visible = bntHuy.Visible = false;
            bntThem.Visible = bntSua.Visible = bntXoa.Visible = true;
            textNS2.Visible = true;
            textNS.Visible = false;
            bntSua.Enabled = true;
            bntThem.Enabled = true;
        }

        private void bntSua_Click(object sender, EventArgs e)
        {
            if (textMa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn muốn sửa gì nào? Phải chọn trước chứ!!!");
            }
            else
            {
                bntHuy.Visible = bntLuu.Visible = true;
                bntThem.Visible = bntXoa.Visible = false;
                bntSua.Enabled = false;
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            if (textMa.Text.Trim() == "")
            {
                MessageBox.Show("Bạn muốn sửa gì nào? Phải chọn trước chứ!!!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn thực sự muốn xóa người này???", "Xóa dữ liệu", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dr)
                {
                    bool ktra = new Connection().XoaHS(id);
                    if (ktra == true)
                    {
                        MessageBox.Show("Xóa thành công");
                        dataHS.DataSource = new Connection().LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa được");
                    }
                }
                else
                {
 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TK;
            TK = textTK.Text.Trim();
            dataHS.DataSource = new Connection().Timkiem(TK);
        }

        private void bntThem2_Click(object sender, EventArgs e)
        {
            bntThem2.Enabled = false;
            bntSua2.Visible = bntXoa2.Visible = false;
            bntLuu2.Visible = bntHuy2.Visible = true;
            textMa2.Clear();
            textTen2.Clear();
            textGT2.Clear();
            textMon.Clear();
            textCV.Clear();
        }

        private void bntSua2_Click(object sender, EventArgs e)
        {
            if (textMa2.Text.Trim() == "")
            {
                MessageBox.Show("Bạn muốn sửa gì nào? Phải chọn trước chứ!!!");
            }
            else
            {
                bntHuy2.Visible = bntLuu2.Visible = true;
                bntThem2.Visible = bntXoa2.Visible = false;
                bntSua2.Enabled = false;
            }
        }

        private void bntXoa2_Click(object sender, EventArgs e)
        {
            if (textMa2.Text.Trim() == "")
            {
                MessageBox.Show("Bạn muốn sửa gì nào? Phải chọn trước chứ!!!");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn thực sự muốn xóa người này???", "Xóa dữ liệu", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dr)
                {
                    bool ktra = new Connection2().XoaGV(id);
                    if (ktra == true)
                    {
                        MessageBox.Show("Xóa thành công");
                        dataGV.DataSource = new Connection2().LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa được");
                    }
                }
                else
                {

                }
            }
        }

        private void bntLuu2_Click(object sender, EventArgs e)
        {
            if (bntThem2.Visible == true)
            {
                if (textTen2.Text.Trim() == "" || textGT2.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn phải nhập dữ liệu vào khung thông tin");
                }
                else
                {
                    Giaovien GV = new Giaovien();
                    GV.Name = textTen2.Text.Trim();
                    GV.GT1 = textGT2.Text.Trim();
                    GV.NS1 = textNS3.Value;
                    GV.Mon1 = textMon.Text.Trim();
                    GV.ChucVu1 = textCV.Text.Trim();
                    bool ktra = new Connection2().ThemGV(GV);
                    if (ktra == true)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công");
                        dataGV.DataSource = new Connection2().LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm được học sinh mới. Hãy thử lại");
                    }
                }
            }
            if (bntSua.Visible == true)
            {
                Giaovien GV = new Giaovien();
                GV.ID1=textMa2.Text.Trim();
                GV.Name = textTen2.Text.Trim();
                GV.GT1 = textGT2.Text.Trim();
                GV.NS1 = textNS3.Value;
                GV.Mon1 = textMon.Text.Trim();
                GV.ChucVu1 = textCV.Text.Trim();
                bool ktra = new Connection2().SuaGV(GV);
                if (ktra == true)
                {
                    MessageBox.Show("Sửa dữ liệu thành công");
                    dataGV.DataSource = new Connection2().LoadData();
                }
                else
                {
                    MessageBox.Show("Không thể Sửa được học sinh mới. Hãy thử lại");
                }
            }
        }

        private void bntHuy2_Click(object sender, EventArgs e)
        {
            bntLuu2.Visible = bntHuy2.Visible = false;
            bntThem2.Visible = bntSua2.Visible = bntXoa2.Visible = true;
            bntSua2.Enabled = true;
            bntThem2.Enabled = true;
        }

        private void bntTKGV_Click(object sender, EventArgs e)
        {
            string TK;
            TK = textTK2.Text.Trim();
            dataGV.DataSource = new Connection2().Timkiem(TK);
        }

        private void dataGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= dataHS.Rows.Count) return;
            textMa2.Text = dataGV.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            textTen2.Text = dataGV.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            textGT2.Text = dataGV.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            textNS3.Value = DateTime.Parse(dataGV.Rows[e.RowIndex].Cells[3].Value.ToString());
            textMon.Text = dataGV.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
            textCV.Text = dataGV.Rows[e.RowIndex].Cells[5].Value.ToString().Trim();
        }

        

    }
}
