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
    public partial class zhufrom : Form
    {
        public zhufrom()
        {
            InitializeComponent();
        }

        #region  控件移动
        List<Label> l = new List<Label>();
        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
          // if ((( Label )sender ).Tag +""=="btn_right .png")
           timer1.Enabled = true;
           l.Add(((Label)sender));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control  item in  panel1.Controls)
            {
                if (item.TabIndex + "" != "1")
                {

                    if (l[0].Tag + "" == "btn_right .png")
                    {
                        item.Left = item.Left - 2;
                    }
                    else
                    {
                        item.Left = item.Left + 2;
                    }
                }
            }
        }

        private void label7_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            l.RemoveAt(0);
        }
        #endregion
      
        private void timer2_Tick(object sender, EventArgs e)
        {
            //获取系统时间
            string time = DateTime.Now + "";
            lblTime.Text = time.Substring(time.IndexOf(' ') + 1);
           
        }
       
        private void label1_Click(object sender, EventArgs e)//生成按钮的单击事件
        {
            if (((Label)sender).Text == "系统管理")
            
            {
                panel4.Controls.Clear();
                xitongForm zhu = new xitongForm();
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            
            }
            else if (((Label)sender).Text == "门诊管理") 
            {
                panel4.Controls.Clear();
                gerenzhongxin zhu = new gerenzhongxin();
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            }
            else if (((Label)sender).Text == "财务管理") 
            {
                panel4.Controls.Clear();
                guanlizhongxin zhu = new guanlizhongxin();
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            }
            else if (((Label)sender).Text == "药房管理")
            {
                panel4.Controls.Clear();
                gerenzhongxin zhu = new gerenzhongxin();
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            }
            else if (((Label)sender).Text == "住院管理")
            {
                panel4.Controls.Clear();
                xiangmuzhuizong zhu = new xiangmuzhuizong();
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            }
            else if (((Label)sender).Text == "门诊收费") 
            {
                panel4.Controls.Clear();
                gerenzhongxin zhu = new gerenzhongxin();
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();
            
            }
            else if (((Label)sender).Text == "药库管理") 
            {
                panel4.Controls.Clear();
                xiangmuzhuizong zhu = new xiangmuzhuizong();
                zhu.TopLevel = false;
                this.panel4.Controls.Add(zhu);
                zhu.Show();

            }    
        }
        List<Label > btn = new List<Label>();
        private void zhufrom_Load(object sender, EventArgs e)//窗体加载事件
        {

            //this.skinEngine1.SkinFile = "MacOS.ssk";
            xitongForm zhu = new xitongForm();
            zhu.TopLevel = false;
            this.panel4.Controls.Add(zhu);
            zhu.Show();
            #region 自动生成按钮
            string[] ss = {  "系统管理", "门诊管理", "财务管理", "药房管理", "住院管理", "门诊收费", "药库管理" };
            int i = 38;
            #endregion
            
            string Data=(DateTime.Now + "");
            string[] data = (DateTime.Now + "").Substring(0,(DateTime.Now + "").IndexOf (' ')).Split('/');
            lblData .Text =data[0]+"年"+data[1] +"月"+data[2] +"日 ";
            /*string date = DateTime.Now.DayOfWeek + "";
            if (date == "Monday") { lblData.Text += "星期一"; }
            else if (date == "Tuesday") { lblData.Text += "星期二"; }
            else if (date == "Wednesday") { lblData.Text += "星期三"; }
            else if (date == "Thursday") { lblData.Text += "星期四"; }
            else if (date == "Friday") { lblData.Text += "星期五"; }
            else if (date == "Saturday") { lblData.Text += "星期六"; }
            else if (date == "Sunday") { lblData.Text += "星期日"; }*/
            xitongForm xitong = new xitongForm();
            xitong.TopLevel = false;
            this.panel4.Controls.Add(xitong);
            xitong.Show();
            panel4.Controls.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  
        private void label6_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            xitongForm zhu = new xitongForm();
            zhu.TopLevel = false;
            this.panel4.Controls.Add(zhu);
            zhu.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            gerenzhongxin zhu = new gerenzhongxin();
            zhu.TopLevel = false;
            this.panel4.Controls.Add(zhu);
            zhu.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            guanlizhongxin zhu = new guanlizhongxin();
            zhu.TopLevel = false;
            this.panel4.Controls.Add(zhu);
            zhu.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            tongjifenxi zhu = new tongjifenxi();
            zhu.TopLevel = false;
            this.panel4.Controls.Add(zhu);
            zhu.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            xiangmucenter zhu = new xiangmucenter();
            zhu.TopLevel = false;
            this.panel4.Controls.Add(zhu);
            zhu.Show();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            xiangmuzhuizong zhu = new xiangmuzhuizong();
            zhu.TopLevel = false;
            this.panel4.Controls.Add(zhu);
            zhu.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            gerenzhongxin zhu = new gerenzhongxin();
            zhu.TopLevel = false;
            this.panel4.Controls.Add(zhu);
            zhu.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
            log2 zh = new log2();
            zh.Show();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#c72d2d");
        }
    }
}
