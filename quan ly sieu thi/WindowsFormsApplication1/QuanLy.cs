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
    public partial class QuanLy : Form
    {
        public User currenUser; 
        public QuanLy(User _curUser)
        {
            InitializeComponent();
            currenUser = _curUser;
            if (currenUser.ID_quanly > 0)
            {
                tab_QL_KH.Hide();
                tab_TKHH.Hide();
                tab_QL_kho.Hide();
                tab_QL_NV.Hide();

            }
        }
       

        private void QLH_TK_checkMH_CheckedChanged(object sender, EventArgs e)
        {
            QLH_TK_boxMA.Enabled = !QLH_TK_boxMA.Enabled;
        }

        private void QLH_TK_checkLH_CheckedChanged(object sender, EventArgs e)
        {
            QLH_TK_checkLH.Enabled = !QLH_TK_checkLH.Enabled;
        }

        private void QLH_TK_checkNN_CheckedChanged(object sender, EventArgs e)
        {
            QLH_TK_checkMH.Enabled = !QLH_TK_checkMH.Enabled;
        }

        private void QLH_TK_butTim_Click(object sender, EventArgs e)
        {
            //truy van csdl theo các trường tìm kiếm đã chọn
        }

        private void TK_checkList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var item in TK_checkList.SelectedItems)
            {
                if (item.ToString() == "Hàng bán chạy")
                {
                    //nạp hàng bán chạy vào data grid view
                }
                if (item.ToString() == "Hàng bán chậm")
                {
                }
                if (item.ToString() == "Hàng mới")
                {
                }
                if (item.ToString() == "Hàng bán gần đây")
                {
                }
            }
                
        }

        private void QLNV_linkTim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ket csdl đổ dữ liệu vào bảng

        }

        private void linkTimKH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //làm tương tự như nhân viên
        }

        private void linkHelp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HuongDan formHD = new HuongDan();
            formHD.ShowDialog();
        }
        
    }
}
