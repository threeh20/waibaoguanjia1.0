using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

using Arction.WinForms.Charting;
using Arction.WinForms.Charting.Axes;
using Arction.WinForms.Charting.SeriesXY;
using Arction.WinForms.Charting.EventMarkers;


namespace UI
{
    public partial class guanlizhongxin : Form
    {
      
        string s="";
        public guanlizhongxin()
        {
            InitializeComponent();
           
        }

       

        private void caiwuForm_Load(object sender, EventArgs e)
        {
           
            xiangmuguanli y = new xiangmuguanli();
            y.TopLevel = false;
            groupBox2.Controls.Add(y);
            y.Show();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
        }
        List<Label> lbl = new List<Label>();
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (lbl.Count != 0 && ((Label)sender).Tag == lbl[0].Tag)
            {
                return;
            }

            string str = (((Label)sender).Tag + "").Replace('-', ' ');
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);

        }

        private void label3_Click(object sender, EventArgs e)
        {

            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
               // lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
           // ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            groupBox2.Controls.Clear();
           

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

           
           
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox2.BackColor);
            e.Graphics.DrawLine(Pens.Red,1,1,1,1);
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox2.BackColor);
            e.Graphics.DrawLine(Pens.Red, 1,7,8 ,7);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
               // lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            //((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            groupBox2.Controls.Clear();
            xiangmuguanli y = new xiangmuguanli();
            y.TopLevel = false;
            groupBox2.Controls.Add(y);
            y.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                //lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            //((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            groupBox2.Controls.Clear();
            xiaoxiguanli y = new xiaoxiguanli();
            y.TopLevel = false;
            groupBox2.Controls.Add(y);
            y.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                // lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            // ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            groupBox2.Controls.Clear();
            yuangongguanli y = new yuangongguanli();
            y.TopLevel = false;
            groupBox2.Controls.Add(y);
            y.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                // lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            // ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            groupBox2.Controls.Clear();
            kaoqinguanli y = new  kaoqinguanli();
            y.TopLevel = false;
            groupBox2.Controls.Add(y);
            y.Show();
        }
    }
}
