using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Drawing.Printing;
using System.Configuration;
namespace UI
{
    public partial class Register_UI1 : Form
    {
        public Register_UI1()
        {
            InitializeComponent();
        }
        
        private void Register_UI_Load(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["strCon"].ToString());
            SqlCommand cmd = new SqlCommand();
            con.Open();
            string str = "select top 1 Rid from Register order by Rid desc";
            cmd.Connection = con;
            cmd.CommandText = str;
            string id = cmd.ExecuteScalar() + "";
            if (id != "")
            {
                string oldId = id.Substring(1);
                int intOldId = Convert.ToInt32(oldId);

                intOldId += 1;
                string strResult = "";
                switch ((intOldId + "").Length)
                {
                    case 1:
                        strResult = "000" + intOldId;
                        break;
                    case 2:
                        strResult = "00" + intOldId;
                        break;
                    case 3:
                        strResult = "0" + intOldId;
                        break;
                    default:
                        strResult = "编号不够了，请升级软件";
                        break;
                }
                txtRid.Text = strResult;



            }
            else
                txtRid.Text = "0001";
            con.Close();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is Label)
                    continue;
                else
                {
                    if (item.Text == "")
                    {
                        PromptingForm p = new PromptingForm("请填写完整信息");
                        p.ShowDialog();
                        return;
                    }

                }

            }
            
        }

        private void cboSectionRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //txtGuaHaoFei.Text = se[cboSectionRoom.SelectedIndex].Sprice + "";
        }

        private void txtKid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Register_UI_Load(null, null);
            foreach (Control item in groupBox1.Controls)
            {
                if (item is Label || item is DateTimePicker || item is CheckBox)
                {
                    continue;
                }
                else
                {
                    if (item.Name != "txtRid")
                    {
                        item.Text = "";
                    }

                }
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is Label || item is DateTimePicker)
                {
                    continue;
                }
                else
                    item.Text = "";
            }
            txtOtherFei.Text = 0 + "";
            txtGuaHaoFei.Text = 0 + "";

        }



        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            

        }
       
        private void cboIdType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }








    }
}
