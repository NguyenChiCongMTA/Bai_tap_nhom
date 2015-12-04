using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Phong
    {
        public int ID { get; set; }
        public DateTime NgayThue { get; set; }
        public DateTime NgayTra { get; set; }
        public string TrangThai { get; set; }
        ThietBi ThietBi ;
        public Phong(string _trangthai,ThietBi thietbi)
        {
            TrangThai = _trangthai;
            ThietBi = thietbi;
        }
        public Phong(DateTime _ngaythue, DateTime _ngaytra)
        {
            NgayThue = _ngaythue;
            NgayTra = _ngaytra;
            if (TrangThai == "Dang su dung")
            {
                if (DateTime.Today <= _ngaytra && DateTime.Today >= NgayThue)
                    TrangThai = "Chua su dung";
            }
        }
        
    }
}
