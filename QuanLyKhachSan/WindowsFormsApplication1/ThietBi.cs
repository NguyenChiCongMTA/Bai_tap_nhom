using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class ThietBi
    {
        public int SoPhong;
        public int Giuong;
        public int Chan;
        public int GaTrai;
        public int Goi;
        public int Quat;
        public int DenNgu;
        public int Ban;
        public int Tu;
        public int Gia;

        public ThietBi()
        {
        }
        public ThietBi(int _So,int _Giuong,int _Chan,int _Ga,int _Goi,int _quat,int _Den,int _ban,int _tu,int _gia)
        {
            SoPhong=_So;
            Giuong=_Giuong;
            Chan=_Chan;
            GaTrai=_Ga;
            Goi=_Goi;
            Quat=_quat;
            DenNgu=_Den;
            Ban=_ban;
            Tu=_tu;
            Gia=_gia;
        }
    }
}
