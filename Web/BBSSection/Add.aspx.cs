using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Common;

namespace BBS.Web.BBSSection
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtSName.Text.Trim().Length==0)
			{
				strErr+="SName不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSMasterID.Text))
			{
				strErr+="SMasterID格式错误！\\n";	
			}
			if(this.txtSStatement.Text.Trim().Length==0)
			{
				strErr+="SStatement不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSClickCount.Text))
			{
				strErr+="SClickCount格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSTopicCount.Text))
			{
				strErr+="STopicCount格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string SName=this.txtSName.Text;
			int SMasterID=int.Parse(this.txtSMasterID.Text);
			string SStatement=this.txtSStatement.Text;
			int SClickCount=int.Parse(this.txtSClickCount.Text);
			int STopicCount=int.Parse(this.txtSTopicCount.Text);

			BBS.Model.BBSSection model=new BBS.Model.BBSSection();
			model.SName=SName;
			model.SMasterID=SMasterID;
			model.SStatement=SStatement;
			model.SClickCount=SClickCount;
			model.STopicCount=STopicCount;

			BBS.BLL.BBSSection bll=new BBS.BLL.BBSSection();
			bll.Add(model);
			Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
