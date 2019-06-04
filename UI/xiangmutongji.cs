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
    public partial class xiangmutongji : Form
    {
        public xiangmutongji()
        {
            InitializeComponent();
        }

        private void Prescribe_UI13_Load(object sender, EventArgs e)
        {
        }

        private void webKitBrowser1_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///D:/waibaoguanjia/tongzhi/FJ-keshihua-tubiao.html");
        }
    }
}
