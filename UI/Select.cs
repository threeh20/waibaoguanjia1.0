using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;

namespace UI
{
    public partial class Select : Form
    {
        public Select()
        {
            InitializeComponent();
        }
        List<Drug_insert> dd = new Drug_insert_BLL().SelectAll("");
        private void btnSelect_Click(object sender, EventArgs e)
        {

            if (txtDname.Text == "")
            {
                PromptingForm p = new PromptingForm("请输入药品名字！");
                p.ShowDialog();
                return;
            }
            lvwShow.Items.Clear();
            List<Drug_insert> di = new Drug_insert_BLL().SelectAll(txtDname.Text);
            if (di.Count == 0)
            {

                PromptingForm p = new PromptingForm("没有你要查找的数据！");
                p.ShowDialog();
                return;
            }
            for (int i = 0; i < di.Count; i++)
            {
                ListViewItem item = new ListViewItem(di[i].Dname + "");
                item.SubItems.Add(di[i].Dtype + "");
                item.SubItems.Add(di[i].DcostName + "");
                item.SubItems.Add(di[i].Dspec + "");
                item.SubItems.Add(di[i].DjiXing + "");
                item.SubItems.Add(di[i].DinsertPrice + "");
                item.SubItems.Add(di[i].DsellPrice + "");
                item.SubItems.Add(di[i].Dstock + "");
                item.SubItems.Add(di[i].DstockMax + "");
                item.SubItems.Add(di[i].DstockMin + "");
                item.SubItems.Add(di[i].DeffectTime + "");
                item.SubItems.Add(di[i].DproductTime + "");
                item.SubItems.Add(di[i].Efficay + "");
                lvwShow.Items.Add(item);
            }
        }



        private void Drug_Select_UI_Load(object sender, EventArgs e)
        {
            button5_Click(null, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lvwShow.Items.Clear();
            if (dd.Where(p => p.Dtype == cboDtype.Text).Count() == 0)
            {
                PromptingForm p = new PromptingForm("没有你要查找的数据！");
                p.ShowDialog();
                return;

            }
            foreach (var d in dd.Where(p => p.Dtype == cboDtype.Text))
            {
                ListViewItem item = new ListViewItem(d.Dname + "");
                item.SubItems.Add(d.Dtype + "");
                item.SubItems.Add(d.DcostName + "");
                item.SubItems.Add(d.Dspec + "");
                item.SubItems.Add(d.DjiXing + "");
                item.SubItems.Add(d.DinsertPrice + "");
                item.SubItems.Add(d.DsellPrice + "");
                item.SubItems.Add(d.Dstock + "");
                item.SubItems.Add(d.DstockMax + "");
                item.SubItems.Add(d.DstockMin + "");
                item.SubItems.Add(d.DeffectTime + "");
                item.SubItems.Add(d.DproductTime + "");
                item.SubItems.Add(d.Efficay + "");
                lvwShow.Items.Add(item);
            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            lvwShow.Items.Clear();
            foreach (var d in dd)
            {
                ListViewItem item = new ListViewItem(d.Dname + "");
                item.SubItems.Add(d.Dtype + "");
                item.SubItems.Add(d.DcostName + "");
                item.SubItems.Add(d.Dspec + "");
                item.SubItems.Add(d.DjiXing + "");
                item.SubItems.Add(d.DinsertPrice + "");
                item.SubItems.Add(d.DsellPrice + "");
                item.SubItems.Add(d.Dstock + "");
                item.SubItems.Add(d.DstockMax + "");
                item.SubItems.Add(d.DstockMin + "");
                item.SubItems.Add(d.DeffectTime + "");
                item.SubItems.Add(d.DproductTime + "");
                item.SubItems.Add(d.Efficay + "");
                lvwShow.Items.Add(item);
            }
        }

        
    }
}
