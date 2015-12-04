using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class HuongDanForm : Form
    {
        public HuongDanForm()
        {
            InitializeComponent();
            string str;
            str = Application.StartupPath + "\\Huong Dan\\HD SD From QL NS.mht";
            webBrowser1.Navigate(str);
        }

        private void HuongDanForm_Load(object sender, EventArgs e)
        {

        }
    }
}
