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


        public static string connectionString = WindowsFormsApplication1.Properties.Settings.Default.QLST;
        public static SqlConnection con = new SqlConnection(connectionString);
        public SqlDataAdapter da = new SqlDataAdapter();
        public DataTable dt = new DataTable();
        public delegate void delPassData(TextBox text);
        private void main_but_OK_Click(object sender, EventArgs e)
        {
            User current_usr = new User();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select * from NHANVIEN where (username=@user) and (pass=@pass)";
            command.Parameters.Add("@user", SqlDbType.NVarChar, 50).Value = main_box_uname.Text;
            command.Parameters.Add("@pass", SqlDbType.NVarChar, 50).Value = main_box_pword.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                
                QuanLy ql = new QuanLy();
                delPassData del = new delPassData(ql.funData);
                del(this.main_box_uname);
                ql.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Sai mật khẩu hoặc tên tài khoản");
            }
        }
    }
}
