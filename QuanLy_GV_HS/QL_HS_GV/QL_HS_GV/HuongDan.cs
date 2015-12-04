using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_HS_GV
{
    public partial class HuongDan : Form
    {
        public HuongDan()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string str;
            if (treeView1.SelectedNode.Name == "HDLogin")
            {
                str = Application.StartupPath + "\\Huongdan\\Login.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_HS")
            {
                str = Application.StartupPath + "\\Huongdan\\HD_HS.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_GV")
            {
                str = Application.StartupPath + "\\Huongdan\\HD_GV.mht";
                webBrowser1.Navigate(str);
            }
            if (treeView1.SelectedNode.Name == "HD_TKB")
            {
                str = Application.StartupPath + "\\Huongdan\\HD_GV.mht";
                webBrowser1.Navigate(str);
            }
        }

        
    }
}
