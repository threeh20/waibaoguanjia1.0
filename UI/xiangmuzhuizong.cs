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
    public partial class xiangmuzhuizong : Form
    {
        string s = "";
        public xiangmuzhuizong()
        {
            InitializeComponent();
           
        }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.Clear(this.BackColor);
        }

        private void Drug_Form_Load(object sender, EventArgs e)
        {
          
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Image = Image.FromFile(Application.StartupPath + "\\imag\\" + ((Label)sender).Tag);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Insert insert = new Insert();
            insert.TopLevel = false;
            panel1.Controls.Add(insert);
            insert.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Select insert = new Select();
            insert.TopLevel = false;
            panel1.Controls.Add(insert);
            insert.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Delete insert = new Delete();
            insert.TopLevel = false;
            panel1.Controls.Add(insert);
            insert.Show();
        }
    }
}
