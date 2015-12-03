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
            //load file html  chứa nội dung hd vào webroser
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
