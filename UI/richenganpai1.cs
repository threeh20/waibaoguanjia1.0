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
    public partial class richenganpai1 : Form
    {
        public richenganpai1()
        {
            InitializeComponent();
        }

        private void Prescribe_UI25_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///C:/Users/Administrator/Desktop/moban1265/index.html");
        }

        private void webKitBrowser1_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///C:/Users/Administrator/Desktop/moban1265/index.html");
        }
    }
}
