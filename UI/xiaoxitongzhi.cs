using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class xiaoxitongzhi : Form
    {
        public xiaoxitongzhi()
        {
            InitializeComponent();
        }
        private void Prescribe_UI20_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///D:/waibaoguanjia/xiaoxi/xiaoxitongzhi-tongzhi.html");
        }
        private void webKitBrowser1_Load(object sender, EventArgs e)
        {

        }
    }
}
