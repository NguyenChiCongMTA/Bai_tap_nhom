using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class User
    {
        public string HoTen;
        public string ID;
        public DateTime NamSinh;
        public int ID_quanly;
        public string BoPhan;
        public string gt;
        public string que;
        public int Luong;
       
        public User()
        {
        }
        public User(string _ten, string _id, DateTime _ns, string _bp, string _gt, string _que, int _luong, int _ql)
        {
            HoTen = _ten;
            ID = _id;
            NamSinh = _ns;
            BoPhan = _bp;
            gt = _gt;
            que = _que;
            Luong = _luong;
            ID_quanly = _ql;
        }
    }
}
