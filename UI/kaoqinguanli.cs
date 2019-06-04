using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class kaoqinguanli : Form
    {
        public kaoqinguanli()
        {
            InitializeComponent();
        }

        private void Prescribe_UI11_Load(object sender, EventArgs e)
        {
        }

        private void webKitBrowser1_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///D:/waibaoguanjia/yuangong/yuangongguanli.html");
        }
    }
}
