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
    public partial class xitongForm1 : Form
    {
        string s = "";
        public xitongForm1()
        {
            InitializeComponent();

        }
        private void label4_Click(object sender, EventArgs e)
        {
            quanxian_Form q = new quanxian_Form();
            q.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Bumen u = new Bumen();
            u.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Jiami u = new Jiami();
            u.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {
            Jiami u = new Jiami();
            u.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Print s = new Print();
            s.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            quanxian_Form q = new quanxian_Form();
            q.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Bumen u = new Bumen();
            u.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            frmSplit chart = new frmSplit();
            chart.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            xiangmuchakan1 ock = new xiangmuchakan1();
            ock.Show();
        }
    }
}
