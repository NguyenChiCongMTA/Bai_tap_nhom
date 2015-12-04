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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void bntDangnhap_Click(object sender, EventArgs e)
        {
            Connection cn = new Connection();
            int kiemtra = new Connection().Login(textID.Text, textPass.Text);
            if (kiemtra == 2)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            if (kiemtra == 1)
            {
                MessageBox.Show("Mật khẩu không đúng. Nhập lại :)");
                textPass.Clear();
                textPass.Focus();
            }
            if (kiemtra == 0)
            {
                MessageBox.Show("Tài khoản không tồn tại");
                textID.Clear();
                textPass.Clear();
                textID.Focus();
            }
        }

        private void bntDangki_Click(object sender, EventArgs e)
        {
            lbEmail.Visible = texEmail.Visible = true;
            texEmail.Text = textID.Text = textPass.Text = null;
            bntDangnhap.Enabled = false;
        }
        
    }
}
