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
    public partial class xiangmucenter : Form
    {
        string s = "";
        public xiangmucenter()
        {
            InitializeComponent();
        }

        private void InHospitalzhu_Load(object sender, EventArgs e)
        {
            

                 
            groupBox2.Controls.Clear();
        }
        int i = 0;
        

        

        void yy(Form ihf)
        {
            ihf.TopLevel = false;
            groupBox2.Controls.Add(ihf);
            ihf.Show();
        }
        List<Label> lbl = new List<Label>();
       
        private void label7_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
           
            //xx(((Label)sender));
        }

        private void label6_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            //InHospital_yujiao inh = new InHospital_yujiao();
           // yy(inh);
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
           // inHospital_zhiban ihf = new inHospital_zhiban();
            //yy(ihf);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            log ihf = new log();
            yy(ihf);
         
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            //InHospital_yujiao ihf = new InHospital_yujiao();
           // yy(ihf);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            //InHospital_yujiao ihf = new InHospital_yujiao();
            //yy(ihf);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
           
        }

        private void label11_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            xiangmuchakan inh = new xiangmuchakan();
            yy(inh);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            xiangmuxiangqing inh = new xiangmuxiangqing();
            yy(inh);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            xiangmuwenjian ihf = new xiangmuwenjian();
            yy(ihf);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            xiangmujindu ihf = new xiangmujindu();
            yy(ihf);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            groupBox2.Controls.Clear();
            xiangmutongzhi ihf = new xiangmutongzhi();
            yy(ihf);
        }
    }
}
