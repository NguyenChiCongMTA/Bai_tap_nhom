using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class hang
    {
        public string TenLoai { get; set; }
        public string Ten { get; set; }
        public string ID { get; set; }
        public string ID_Loai { get; set; }
        public DateTime tg_nhap ;
        public DateTime tg_ban ;
        public int gia { get; set; }
        public string image_url;
        public hang()
        {
        }
        public hang(string _ID, string _ID_Loai, DateTime _tg_nhap, int _gia, string _imageurl)
        {
            ID = _ID;
            ID_Loai = _ID_Loai;
            tg_nhap = _tg_nhap;
            gia = _gia;
            image_url = _imageurl;
        }
    }
}
