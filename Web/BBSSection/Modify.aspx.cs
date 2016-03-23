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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int SID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(SID);
				}
			}
		}
			
	private void ShowInfo(int SID)
	{
		BBS.BLL.BBSSection bll=new BBS.BLL.BBSSection();
		BBS.Model.BBSSection model=bll.GetModel(SID);
		this.lblSID.Text=model.SID.ToString();
		this.txtSName.Text=model.SName;
		this.txtSMasterID.Text=model.SMasterID.ToString();
		this.txtSStatement.Text=model.SStatement;
		this.txtSClickCount.Text=model.SClickCount.ToString();
		this.txtSTopicCount.Text=model.STopicCount.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int SID=int.Parse(this.lblSID.Text);
			string SName=this.txtSName.Text;
			int SMasterID=int.Parse(this.txtSMasterID.Text);
			string SStatement=this.txtSStatement.Text;
			int SClickCount=int.Parse(this.txtSClickCount.Text);
			int STopicCount=int.Parse(this.txtSTopicCount.Text);


			BBS.Model.BBSSection model=new BBS.Model.BBSSection();
			model.SID=SID;
			model.SName=SName;
			model.SMasterID=SMasterID;
			model.SStatement=SStatement;
			model.SClickCount=SClickCount;
			model.STopicCount=STopicCount;

			BBS.BLL.BBSSection bll=new BBS.BLL.BBSSection();
			bll.Update(model);
			Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
