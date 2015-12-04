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
    public partial class FormLogin : Form
    {
        public FormLogin()
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
                ThongTin tg = new ThongTin();
                tg.Show();
                FormLogin fm = new FormLogin();
                fm.Close();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HuongDan hd = new HuongDan();
            hd.Show();
        }
        
    }
}
