using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    public partial class jiaoliufenxiang : Form
    {
        public jiaoliufenxiang()
        {
            InitializeComponent();
            //System.IO.FileInfo file = new System.IO.FileInfo(@"\a\index.html");
            // WebBrowser控件显示的网页路径
            //webBrowser1.Url = new Uri(file.FullName);
            // 将当前类设置为可由脚本访问
            //webBrowser1.ObjectForScripting = this;
        }
        private void webKitBrowser1_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///D:/waibaoguanjia/geren/jiaoliufenxiang.html");

        }
    }

}
