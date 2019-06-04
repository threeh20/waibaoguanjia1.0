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
    public partial class IdCard_UI2 : Form
    {
        public IdCard_UI2()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox || item is ComboBox)
                    if (item.Text == "")
                    {
                        PromptingForm p = new PromptingForm("请把信息填写完整！");
                        p.ShowDialog();
                        return;
                    }
            }


            IdCard IC = new IdCard();
            IC.Name = txtName.Text;
            if (rdoBoy.Checked)
                IC.Sex = rdoBoy.Text;
            else
                IC.Sex = rdoGirl.Text;
            IC.Age = int.Parse(txtAge.Text);
            IC.Birthday = "0";
            
            IC.Phone = txtPhone.Text;
            IC.Nation = cboNation.Text;
            IC.Cultrue = cboCultrue.Text;
            if (rdoMarriageYes.Checked)
                IC.Marriage = rdoMarriageYes.Text;
            else
                IC.Marriage = rdoMarriageNo.Text;
            IC.Work = cboWork.Text;
            IC.Postcode =txtPostcode.Text;
            IC.IdcardNo = txtIdcardNo.Text;

            string mes = new IdCard_BLL().Reg(IC);
            if (mes == "该身份证已注册过绿卡")
            {
                PromptingForm pp1 = new PromptingForm("该身份证已注册过绿卡");
                pp1.ShowDialog();
                return;
            }
            else if (mes == "注册失败")
            {
                PromptingForm pp2 = new PromptingForm("注册失败");
                pp2.ShowDialog();
                return;
            }
            string s = new IdCard_BLL().p_IdCard_select();

            PromptingForm pp = new PromptingForm("注册成功!卡号为：" + s);
            pp.ShowDialog();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IdCard_UI_Load(object sender, EventArgs e)
        {

        }
    }
}
