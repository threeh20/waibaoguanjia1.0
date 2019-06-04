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
    public partial class xiangmuxiangqing : Form
    {
        public xiangmuxiangqing()
        {
            InitializeComponent();
        }

        private void Prescribe_UI10_Load(object sender, EventArgs e)
        {
        }
        private void webKitBrowser2_Load(object sender, EventArgs e)
        {
            webKitBrowser2.Navigate("file:///D:/waibaoguanjia/xiaoxi/xiangmuguanli.html");
        }
    }
}
