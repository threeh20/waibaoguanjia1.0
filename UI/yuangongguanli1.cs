﻿using System;
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
    public partial class yuangongguanli1 : Form
    {
        public yuangongguanli1()
        {
            InitializeComponent();
        }

        private void Prescribe_UI16_Load(object sender, EventArgs e)
        {
        }

        private void webKitBrowser1_Load_1(object sender, EventArgs e)
        {
            webKitBrowser1.Navigate("file:///D:/waibaoguanjia/yuangongguanli/J-yuangongguanli.html");
        }
    }
}
