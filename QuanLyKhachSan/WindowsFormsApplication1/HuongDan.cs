using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
            string str;
            str = Application.StartupPath + "\\Huong Dan\\HD SD From QL KS.mht";
            webBrowser1.Navigate(str);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
