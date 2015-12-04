using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QL_HS_GV.Class
{
    class Connection2
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection con;
        public Connection2()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            con = new SqlConnection(connectionString);
        }

        public bool isConnect()
        {
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
                    throw new Exception("Connection err!");
                }
            }
            catch (Exception e)
            {
            }
            return connect;
        }

        public DataTable LoadData()
        {
            DataTable dt = new DataTable();
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "LoadGV";
                com.CommandType = CommandType.StoredProcedure;
                com.Connection = con;
                SqlDataAdapter ad = new SqlDataAdapter(com);
                ad.Fill(dt);
            }
            con.Close();
            return dt;
        }
        public bool ThemGV(Giaovien GV)
        {
            bool ktra = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "ThemGV";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@HoTen", GV.Name);
                com.Parameters.AddWithValue("@GT", GV.GT1);
                com.Parameters.AddWithValue("@NS", GV.NS1);
                com.Parameters.AddWithValue("@Mon", GV.Mon1);
                com.Parameters.AddWithValue("@CV", GV.ChucVu1);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                ktra = i > 0 ? true : false;
            }
            con.Close();
            return ktra;
        }
        public bool SuaGV(Giaovien GV)
        {
            bool ktra = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "SuaGV";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", GV.ID1);
                com.Parameters.AddWithValue("@HoTen", GV.Name);
                com.Parameters.AddWithValue("@GT", GV.GT1);
                com.Parameters.AddWithValue("@NS", GV.NS1);
                com.Parameters.AddWithValue("@Mon", GV.Mon1);
                com.Parameters.AddWithValue("@CV", GV.ChucVu1);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                ktra = i > 0 ? true : false;
            }
            con.Close();
            return ktra;
        }

        public bool XoaGV(string id)
        {
            bool ktra = false;
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "XoaGV";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@ID", id);
                com.Connection = con;
                int i = com.ExecuteNonQuery();
                ktra = i > 0 ? true : false;
            }
            con.Close();
            return ktra;
        }

        public DataTable Timkiem(string TK)
        {
            DataTable dt = new DataTable();
            if (isConnect())
            {
                SqlCommand com = new SqlCommand();
                com.CommandText = "TimKiem2";
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@TK", TK);
                com.Connection = con;
                com.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter(com);
                ad.Fill(dt);
            }
            con.Close();
            return dt;
        }
    }
}
