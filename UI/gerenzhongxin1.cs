using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;


namespace UI
{
    public partial class gerenzhongxin1 : Form
    {
        public gerenzhongxin1()
        {
            InitializeComponent();

        }
        List<Label> lbl = new List<Label>();
        private void label1_Click(object sender, EventArgs e)
        {

            pancontrols.Controls.Clear();
            Register_UI reg = new Register_UI();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

            pancontrols.Controls.Clear();
           
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            if (lbl.Count != 0 && ((Label)sender).Tag == lbl[0].Tag)
            {
                return;
            }

            string str = (((Label)sender).Tag + "").Replace('-', ' ');
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);

        }
        string s = "";
        private void clinic_Load(object sender, EventArgs e)
        {

            lbl.Add(((Label)label1));

            pancontrols.Controls.Clear();
            xiaoxitongzhi1 reg = new xiaoxitongzhi1();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            lbl.Add(((Label)sender));
            pancontrols.Controls.Clear();
        }


        private void label6_Click(object sender, EventArgs e)
        {

            lbl.Add(((Label)sender));
            // ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            pancontrols.Controls.Clear();
           
        }
        public sealed class ActivationContext : IDisposable, ISerializable
        {
            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                throw new NotImplementedException();
            }

            void IDisposable.Dispose()
            {
                throw new NotImplementedException();
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                //lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            //((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            pancontrols.Controls.Clear();
            Register_UI reg = new Register_UI();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            lbl.Add(((Label)sender));
            //((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            pancontrols.Controls.Clear();
            xiaoxitongzhi1 reg = new xiaoxitongzhi1();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                // lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            //((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            pancontrols.Controls.Clear();
            gerenxinxi1 reg = new gerenxinxi1();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (lbl.Count != 0)
            {
                string str = (lbl[0].Tag + "").Replace('-', ' ');
                // lbl[0].Image = Image.FromFile(Application.StartupPath + "\\imag\\" + str);
                lbl.Clear();
            }
            lbl.Add(((Label)sender));
            //((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            pancontrols.Controls.Clear();
            jiaoliufenxiang reg = new jiaoliufenxiang();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            lbl.Add(((Label)sender));
            //((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
            pancontrols.Controls.Clear();
            richenganpai reg = new richenganpai();
            reg.TopLevel = false;
            pancontrols.Controls.Add(reg);
            reg.Show();
        }
    }
}
