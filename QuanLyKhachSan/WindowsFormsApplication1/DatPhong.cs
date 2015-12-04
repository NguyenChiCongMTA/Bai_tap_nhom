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
    public partial class DPform : Form
    {
        public DPform()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DP_butOK_Click(object sender, EventArgs e)
        {
            DP_panPT.Enabled = true;
            DP_dataPhong.DataSource = connect.LoadPhongCSD();
            //truy van csdl tim phong trong thoi gian dat
            //Mỗi hàng kết quả tìm được có 1 cột thuộc kiểu checked box
            bool i = connect.ThemKH(DP_boxTenKH.Text,DP_boxIDKH.Text,DP_dateNS_KH.Value,DP_boxDC_KH.Text);

        }
        public int ma;
        private void DP_butXN_Click(object sender, EventArgs e)
        {
            bool i = connect.DatHang(DP_boxIDKH.Text, ma, DateTime.Now, DP_dateTGbd.Value, DP_dateTGkt.Value);   
            // //phòng nào đặt thì check hàng tương ứng , cập nhật những phòng được check vào csdl
            if (i) MessageBox.Show("Dat phong thanh cong");
            else MessageBox.Show("That bai");
            this.Close();
        }

        private void DP_dataPhong_Click(object sender, EventArgs e)
        {
            DP_dataPhong.DataSource = connect.LoadPhongCSD();
        }

        private void DP_dataPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ma = Convert.ToInt16(DP_dataPhong.Rows[e.RowIndex].Cells[0].Value.ToString());
            MessageBox.Show("Chon phong " + ma);
        }
    }
}
