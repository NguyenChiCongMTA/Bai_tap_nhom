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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void main_but_OK_Click(object sender, EventArgs e)
        {
            //truy van csdl xem co nguoi dung ko
            //Nếu có khai báo biến người dùng  , mở form quản lí
            User current_usr = new User();
            //đẩy thông tin người dùng vào curren_user 
            QuanLy formQL = new QuanLy(current_usr);
            formQL.Show();
            this.Hide();

        }
    }
}
