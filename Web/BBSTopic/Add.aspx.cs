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

namespace BBS.Web.BBSTopic
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txttsid.Text))
			{
				strErr+="tsid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttuid.Text))
			{
				strErr+="tuid格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txttreplycount.Text))
			{
				strErr+="treplycount格式错误！\\n";	
			}
			if(this.txtTTopic.Text.Trim().Length==0)
			{
				strErr+="TTopic不能为空！\\n";	
			}
			if(this.txtTContents.Text.Trim().Length==0)
			{
				strErr+="TContents不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTTime.Text))
			{
				strErr+="TTime格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTClickCount.Text))
			{
				strErr+="TClickCount格式错误！\\n";	
			}
			if(!PageValidate.IsDateTime(txtTLastClickT.Text))
			{
				strErr+="TLastClickT格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int tsid=int.Parse(this.txttsid.Text);
			int tuid=int.Parse(this.txttuid.Text);
			int treplycount=int.Parse(this.txttreplycount.Text);
			string TTopic=this.txtTTopic.Text;
			string TContents=this.txtTContents.Text;
			DateTime TTime=DateTime.Parse(this.txtTTime.Text);
			int TClickCount=int.Parse(this.txtTClickCount.Text);
			DateTime TLastClickT=DateTime.Parse(this.txtTLastClickT.Text);

			BBS.Model.BBSTopic model=new BBS.Model.BBSTopic();
			model.tsid=tsid;
			model.tuid=tuid;
			model.treplycount=treplycount;
			model.TTopic=TTopic;
			model.TContents=TContents;
			model.TTime=TTime;
			model.TClickCount=TClickCount;
			model.TLastClickT=TLastClickT;

			BBS.BLL.BBSTopic bll=new BBS.BLL.BBSTopic();
			bll.Add(model);
			Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
