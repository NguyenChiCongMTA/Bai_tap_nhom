using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class HuongDan_form : Form
    {
        public HuongDan_form()
        {
            InitializeComponent();
            string str;
            str = Application.StartupPath + "\\Huong Dan\\HD SD From QL Kho.mht";
            webBrowser1.Navigate(str);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //load file html vao day
        }
    }
}
