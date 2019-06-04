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
    public partial class xiangmuwenjian : Form
    {
        public xiangmuwenjian()
        {
            InitializeComponent();
        }

        private void Prescribe_UI14_Load(object sender, EventArgs e)
        {
        }

        private void webKitBrowser1_Load(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///D:/waibaoguanjia/wenjian/xiangmuwenjian.html");
        }
    }
}
