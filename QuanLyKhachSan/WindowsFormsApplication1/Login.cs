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
namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private static string connectionString = WindowsFormsApplication1.Properties.Settings.Default.QLKS;
        private static SqlConnection con = new SqlConnection(connectionString);
        private SqlDataAdapter da = new SqlDataAdapter();
        private DataTable dt = new DataTable();
        
        private void Login_but_ok_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select username,pass from NHANVIEN where (username=@user) and (pass=@pass)";
            command.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = Login_uname_box.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar, 50).Value = Login_pword_box.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                QLKS ql = new QLKS();
                ql.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Sai mật khẩu hoặc tên tài khoản");
            }
            //kiem tra csdl xem co nguoi dung
            
        }
    }
}
