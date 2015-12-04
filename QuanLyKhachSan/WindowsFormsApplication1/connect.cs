using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class connect
    {
        private static string connectionString = WindowsFormsApplication1.Properties.Settings.Default.QLKS;
        private static SqlConnection con;

        public connect()
        {

        }
        public static bool isConnect()
        {
            connectionString = WindowsFormsApplication1.Properties.Settings.Default.QLKS;
            con = new SqlConnection(connectionString);
            bool connect = false;
            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    connect = true;
                }
                else
                {
                    throw new Exception("ko ket noi");
                }
            }
            catch (Exception ex)
            {
            }
            return connect;
        }

        public static DataTable LoadFullPhong()
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "select * from Phong";
                com.CommandType = CommandType.Text;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable LoadPhongSD()
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "select * from Phong where Trangthai='Dang su dung'";
                com.CommandType = CommandType.Text;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable LoadPhongCSD()
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "select * from Phong where Trangthai='Chua su dung'";
                com.CommandType = CommandType.Text;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable TimPhong(string SP)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "select * from Phong where SoPhong='"+SP+"'";
                com.CommandType = CommandType.Text;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable TimPhongTG(DateTime dat, DateTime tra)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "TimPhong";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = con;
                com.Parameters.AddWithValue("@tgdat",dat );
                com.Parameters.AddWithValue("@tgtra",tra);
               
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable LoadFullKH()
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "Load_KhachHang";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable Load_KHDT(DateTime tg)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "Load_KhachHangDT";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@tg", tg);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable Load_KHDaT(DateTime tg)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "Load_KhachHangDaT";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@tg", tg);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable TimKH_CMND(string CMND)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "Load_KHCMND";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@cmnd", CMND);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable TimKH_Ten(string ten)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "Load_KHTen";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ten", ten);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }
        public static DataTable TimKH_TG(DateTime tgbd,DateTime tgkt)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "Load_KHTG";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@tgbd", tgbd);
                com.Parameters.AddWithValue("@tgkt", tgkt);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);

            }
            return table;
        }

        public static bool ThemKH(string ten, string cmnd,DateTime ns,string dc)
        {
            bool them=false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "ThemKH";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ten", ten);
                com.Parameters.AddWithValue("@cmnd", cmnd);
                com.Parameters.AddWithValue("@ns", ns);
                com.Parameters.AddWithValue("@dc", dc);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                them = i > 0 ? true : false;

            }
            return them;
        }
        public static bool DatHang(string cmnd, int ma,DateTime ndk,DateTime nden,DateTime ndi)
        {
            bool them = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "Them_DatHang";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@cmnd", cmnd);
                com.Parameters.AddWithValue("@maphong", ma);
                com.Parameters.AddWithValue("@ndk", ndk);
                com.Parameters.AddWithValue("@nden", nden);
                com.Parameters.AddWithValue("@ndi", ndi);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                them = i > 0 ? true : false;

            }
            return them;
        }
    }
}
