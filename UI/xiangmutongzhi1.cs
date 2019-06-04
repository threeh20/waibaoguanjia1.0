using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebKit;

namespace UI
{
    public partial class xiangmutongzhi1 : Form
    {
        public xiangmutongzhi1()
        {
           InitializeComponent();
            //System.IO.FileInfo file = new System.IO.FileInfo(@"\a\index.html");
            // WebBrowser控件显示的网页路径
            //webBrowser1.Url = new Uri(file.FullName);
            // 将当前类设置为可由脚本访问
            //webBrowser1.ObjectForScripting = this;
        }

        
        private void Prescribe_UI2_Load(object sender, EventArgs e)
        {

        }

        private void webKitBrowser1_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///D:/waibaoguanjia/xiangmu2/xiangmutongzhi1.html");
        }
    }

}
