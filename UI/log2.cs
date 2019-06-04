using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using BLL;
using Paway.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Face;

namespace UI
{
    public partial class log2 : Form
    {
        public log2()
        {
            InitializeComponent();
            NotifyForm.AnimalShow("消息提示", "您的云帐号于 2018/4/15 9:04 在 杭州 登录外包客户端,登陆 IP: 112.10.129.209 ,为了保证您的账号安全，请确认是否为您本人操作。");
            this.contextMenuStrip1.Renderer = new QQToolStripRenderer();
        }

        List<Label> lbl = new List<Label>();

        private void txtUname_TextChanged(object sender, EventArgs e)
        {
            lblUname.Visible = false;
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            lblPwd.Visible = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {


            web zhu = new web();
            zhu.Tag = txtUname.Text;
            zhu.Show();
            this.Hide();

        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#c72d2d");
            skinEngine1.SkinFile = Application.StartupPath + @"\DiamondBlue.ssk";
            lblUname.Visible = false;
            lblPwd.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Face.MainWindow wpfwindow = new Face.MainWindow();
            //wpfwindow.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            IdCard_UI2 reg = new IdCard_UI2();


            reg.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {
            IdCard_UI2 reg = new IdCard_UI2();


            reg.Show();
        }

        private void qqButton1_Click_1(object sender, EventArgs e)
        {
            Users u = new Users();
            u.Uname = txtUname.Text;
            u.Pwd = txtPwd.Text;
            int i = new UsersBLL().Check(u);

            if (txtUname.Text == "")
            {
                lblUname.Visible = true;
                lblUname.Text = "用户名不能为空";
                return;
            }
            else if (txtPwd.Text == "")
            {
                lblPwd.Visible = true;
                lblPwd.Text = "密码不能为空";
                return;
            }
            else if (i == 1)
            {
                lblPwd.Visible = true;

                lblPwd.Text = "密码不正确";
                return;
            }
            else if (i == 0)
            {
                lblUname.Visible = true;

                lblUname.Text = "没有此用户";
                return;
            }
            else if (i == 3)
            {
                MessageBox.Show("系统错误");
                return;
            }
            if (qqRadioButton1.Checked)
            {
                Form12 one = new Form12();
                one.Tag = txtUname.Text;
                one.Show();
                this.Hide();
                //zhufrom zhu = new zhufrom();
                // zhu.Tag = txtUname.Text;
                //zhu.Show();
                //this.Hide();
            }
            else if (qqRadioButton2.Checked)
            {
                //Form1 one = new Form1();
                //one.Show();
                //this.Hide();
                xieyi zhu = new xieyi();
                zhu.Tag = txtUname.Text;
                zhu.Show();
                this.Hide();
            }

        }

        private void label19_Click_1(object sender, EventArgs e)
        {
            IdCard_UI2 reg = new IdCard_UI2();


            reg.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Face.MainWindow wpfwindow = new Face.MainWindow();
            wpfwindow.ShowDialog();
        }
    }
}
