﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;  //导入反射的命名空间
namespace UI
{
    public partial class quanxian_Form1 : Form
    {
        public quanxian_Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                foreach (CheckBox item in groupBox1.Controls)
                {
                    item.Enabled = true;
                }
            }
            else
            {

                foreach (CheckBox item in groupBox1.Controls)
                {
                    if (item.Name != "checkBox1")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                foreach (CheckBox item in groupBox2.Controls)
                {
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox2.Controls)
                {
                    if (item.Name != "checkBox2")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                foreach (CheckBox item in groupBox3.Controls)
                {
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox3.Controls)
                {
                    if (item.Name != "checkBox3")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                foreach (CheckBox item in groupBox4.Controls)
                {

                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox4.Controls)
                {
                    if (item.Name != "checkBox4")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                foreach (CheckBox item in groupBox5.Controls)
                {

                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox5.Controls)
                {
                    if (item.Name != "checkBox5")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                foreach (CheckBox item in groupBox6.Controls)
                {

                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox6.Controls)
                {
                    if (item.Name != "checkBox6")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                foreach (CheckBox item in groupBox7.Controls)
                {

                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox7.Controls)
                {
                    if (item.Name != "checkBox7")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                foreach (CheckBox item in groupBox8.Controls)
                {

                    item.Enabled = true;
                }
            }
            else
            {
                foreach (CheckBox item in groupBox8.Controls)
                {
                    if (item.Name != "checkBox8")
                    {
                        item.Checked = false;
                        item.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control ite in item.Controls)
                    {
                        if (ite is CheckBox)
                        {
                            if (((CheckBox)ite).Checked)
                                str += ite.Text + "-";
                        }
                    }
                }
            }
            if (textBox1.Text != "")
            {
               
                PromptingForm pp = new PromptingForm("保存成功！");
                pp.ShowDialog();
                quanxian_Form_Load(null, null);
            }
            else if (textBox3.Text != "")
            {
                
                PromptingForm pp = new PromptingForm("保存成功！");

                pp.ShowDialog();
                quanxian_Form_Load(null, null);
            }


        }

        private void 添加类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            quanxian_Form_Load(null, null);
        }
        
        private void quanxian_Form_Load(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView1.Items.Clear();
            

            //Table<Users> tq = con.GetTable<Users>();
            ////将表对象转为集合对象
            //questions = tq.ToList();
            ////将tq表中的数据显示到DataGridView中
            //dgvQuestion.DataSource = questions;

            //将tq表中的数据显示到ListView中
            //foreach (Users q in us)
            //{
            //    ListViewItem item = new ListViewItem(q.Uname + "");
            //    //获取q对象中的所有属性
            //    PropertyInfo[] ps = q.GetType().GetProperties();
            //    foreach (PropertyInfo p in ps)
            //    {
            //        if (p.Name != "Uname")//排除第一个属性
            //        {  //获取q对象每个属性对应的值
            //            continue;
            //        }
            //        item.SubItems.Add(p.GetValue(q, null) + "");

            //    }
            //    listView1.Items.Add(item);
            //}

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is GroupBox)
                {
                    foreach (Control ite in item.Controls)
                    {
                        if (ite is CheckBox)
                        {
                            ((CheckBox)ite).Checked = false;

                        }
                    }
                }
            }


            if (listView2.SelectedItems.Count > 0)
            {
                textBox1.Text = listView2.SelectedItems[0].Text;
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void 删除类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                string str = listView2.SelectedItems[0].Text;
                
                PromptingForm p = new PromptingForm("删除成功！");
                p.ShowDialog();
                quanxian_Form_Load(null, null);
            }
            else
            {
                PromptingForm p = new PromptingForm("没有选中要删除的数据");
                p.ShowDialog();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (Control item in Controls)
                {
                    if (item is GroupBox)
                    {
                        foreach (Control ite in item.Controls)
                        {
                            if (ite is CheckBox)
                            {
                                ((CheckBox)ite).Checked = false;

                            }
                        }
                    }
                }
                textBox3.Text = listView1.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox1.Text = "";
                
            }
        }

        private void checkBox46_CheckedChanged(object sender, EventArgs e)
        {
           
        }

    }
}

