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
    public partial class gerenxinxi1 : Form
    {
        public gerenxinxi1()
        {
            InitializeComponent();
        }

        private void Prescribe_UI24_Load(object sender, EventArgs e)
        {
        }

        private void webKitBrowser1_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///D:/waibaoguanjia/yuangong1/jiebaofanggerenjiemian.html");
        }
    }
}
