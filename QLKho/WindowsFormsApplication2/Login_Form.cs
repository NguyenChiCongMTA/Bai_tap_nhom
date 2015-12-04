using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private static string connectionString = WindowsFormsApplication2.Properties.Settings.Default.QLKho;
        private static SqlConnection con = new SqlConnection(connectionString);
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();

        private void Login_but_ok_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select username,pass from NHANVIEN where (username=@user) and (pass=@pass)";
            command.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = textBox1.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar, 50).Value = Login_box_pword.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                QL_Form ql = new QL_Form();
                ql.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Sai mật khẩu hoặc tên tài khoản");
            }
            //kiem tra csdl xem co nguoi dung

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //show form html hướng dẫn lên
        }
    }
}
