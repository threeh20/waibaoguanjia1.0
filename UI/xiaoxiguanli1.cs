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
    public partial class xiaoxiguanli1 : Form
    {
        public xiaoxiguanli1()
        {
            InitializeComponent();
        }

        private void Prescribe_UI7_Load(object sender, EventArgs e)
        {

        }

        private void webKitBrowser1_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///D:/waibaoguanjia/xiaoxi/xiaoxitongzhi-chakan1.html");

        }
    }
}
