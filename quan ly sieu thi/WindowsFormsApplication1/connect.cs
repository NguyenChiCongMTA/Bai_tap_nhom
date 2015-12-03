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
        private static string connectionString = WindowsFormsApplication1.Properties.Settings.Default.QLST;
        private static SqlConnection con;

        public connect()
        {

        }
        public static bool isConnect()
        {
            connectionString = WindowsFormsApplication1.Properties.Settings.Default.QLST;
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

        public static User LoadNV(string username)
        {
            User nv = new User();
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "select * from NhanVien where username='"+username+"'";
                com.CommandType = CommandType.Text;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read()) 
                {
                    nv.HoTen = dr[1].ToString();
                    nv.ID_quanly = Convert.ToInt16(dr[0].ToString());
                    nv.ID = dr[2].ToString();
                    nv.Luong = Convert.ToInt32(dr[7].ToString());
                    nv.NamSinh = Convert.ToDateTime(dr[4].ToString());
                    nv.gt = dr[6].ToString();
                    nv.BoPhan = dr[5].ToString();
                    nv.que = dr[8].ToString();
                }

            }
            return nv;
        }
        public static bool BanHang(string ten,int sl)
        {
            bool ban = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "BanHang";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ten", ten);
                com.Parameters.AddWithValue("@sl", sl);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                ban = i > 0 ? true : false;
            }
            return ban;
        }
        public static int LoadGia(string name)
        {
            DataTable table = null;
            int gia=0;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                //com.CommandText = "select  from NHANVIEN";
                com.CommandText = "select DonGia from Hang where username='" + name + "'";
                com.CommandType = CommandType.Text;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    gia = Convert.ToInt32(dr[0].ToString());
                }

            }
            return gia;
        }
        public static DataTable Tim_HangXuat(string ma)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "Tim_HangXuat";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ma", ma);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }
        public static DataTable Tim_HangNhap(string ma)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "Tim_HangNhap";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ma", ma);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }
        public static DataTable TK_HangChay()
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "TK_HangChay";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }
        public static DataTable TK_HangCham()
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "TK_HangCham";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }
        public static DataTable TK_HangGanDay()
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "TK_HangGanDay";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }

        public static DataTable TK_NV_Ten(string ten)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "TK_NV_Ten";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ten", ten);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }
        public static DataTable TK_NV_Ma(string ma)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "TK_NV_Ma";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ma", ma);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }
        public static DataTable TK_KH_Ten(string ten)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "TK_KH_Ten";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ten", ten);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }
        public static DataTable TK_KH_Ma(string cmnd)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "TK_KH_Ma";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@cmnd", cmnd);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }
        public static DataTable TK_HangMoi(DateTime tg)
        {
            DataTable table = null;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "TK_HangMoi";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@tg", tg);
                com.Connection = con;
                SqlDataAdapter adap = new SqlDataAdapter(com);
                table = new DataTable();
                adap.Fill(table);
            }
            return table;
        }
        public static bool Them_NV(string ma, string ten, int luong,string bophan, string gioitinh,DateTime ns)
        {
            bool ban = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "Them_NV";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ma", ma);
                com.Parameters.AddWithValue("@ten", ten);
                com.Parameters.AddWithValue("@l", luong);
                com.Parameters.AddWithValue("@bp", bophan);
                com.Parameters.AddWithValue("@gt", gioitinh);
                com.Parameters.AddWithValue("@ns", ns);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                ban = i > 0 ? true : false;
            }
            return ban;
        }
        public static bool Sua_NV(string ma, string ten, int luong, string bophan, string gioitinh, DateTime ns)
        {
            bool ban = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "Sua_NV";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ma", ma);
                com.Parameters.AddWithValue("@ten", ten);
                com.Parameters.AddWithValue("@l", luong);
                com.Parameters.AddWithValue("@bp", bophan);
                com.Parameters.AddWithValue("@gt", gioitinh);
                com.Parameters.AddWithValue("@ns", ns);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                ban = i > 0 ? true : false;
            }
            return ban;
        }
        public static bool Xoa_NV(string ma)
        {
            bool ban = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "Xoa_NV";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ma", ma);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                ban = i > 0 ? true : false;
            }
            return ban;
        }
        public static bool Them_KH(KhachHang k)
        {
            bool ban = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "Them_KH";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ten", k.HoTen);
                com.Parameters.AddWithValue("@cmnd", k.CMND);
                com.Parameters.AddWithValue("@diachi", k.DiaChi);
                com.Parameters.AddWithValue("@nlv", k.NoiLamViec);
                com.Parameters.AddWithValue("@ns", k.NS);
                com.Parameters.AddWithValue("@sdt", k.SDT);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                ban = i > 0 ? true : false;
            }
            return ban;
        }
        public static bool Xoa_KH(string cmnd)
        {
            bool ban = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "Xoa_KH";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@cmnd", cmnd);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                ban = i > 0 ? true : false;
            }
            return ban;
        }
    }
}
