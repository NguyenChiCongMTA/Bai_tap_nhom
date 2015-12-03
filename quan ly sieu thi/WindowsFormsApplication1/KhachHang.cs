using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class KhachHang
    {
       public string HoTen { get; set; }
       public string SDT { get; set; }
       public string CMND { get; set; }
       public string DiaChi { get; set; }
       public string NoiLamViec { get; set; }
       public DateTime NS { get; set; }

       public KhachHang()
       {
       }
       public KhachHang(string _HoTen, string _SDT, string _CMND, string _DiaChi, string _NoiLamViec,DateTime _ns)
       {
           HoTen = _HoTen;
           CMND = _CMND;
           SDT = _SDT;
           DiaChi = _DiaChi;
           NoiLamViec = _NoiLamViec;
           NS = _ns;
       }
    }
}
