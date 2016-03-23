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

namespace BBS.Web.BBSReply
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtRTID.Text))
			{
				strErr+="RTID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRSID.Text))
			{
				strErr+="RSID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRUID.Text))
			{
				strErr+="RUID格式错误！\\n";	
			}
			if(this.txtRTopic.Text.Trim().Length==0)
			{
				strErr+="RTopic不能为空！\\n";	
			}
			if(this.txtRContents.Text.Trim().Length==0)
			{
				strErr+="RContents不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtRTime.Text))
			{
				strErr+="RTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtRClickCount.Text))
			{
				strErr+="RClickCount格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int RTID=int.Parse(this.txtRTID.Text);
			int RSID=int.Parse(this.txtRSID.Text);
			int RUID=int.Parse(this.txtRUID.Text);
			string RTopic=this.txtRTopic.Text;
			string RContents=this.txtRContents.Text;
			DateTime RTime=DateTime.Parse(this.txtRTime.Text);
			int RClickCount=int.Parse(this.txtRClickCount.Text);

			BBS.Model.BBSReply model=new BBS.Model.BBSReply();
			model.RTID=RTID;
			model.RSID=RSID;
			model.RUID=RUID;
			model.RTopic=RTopic;
			model.RContents=RContents;
			model.RTime=RTime;
			model.RClickCount=RClickCount;

			BBS.BLL.BBSReply bll=new BBS.BLL.BBSReply();
			bll.Add(model);
			Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
