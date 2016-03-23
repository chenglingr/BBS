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
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int tid=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(tid);
				}
			}
		}
			
	private void ShowInfo(int tid)
	{
		BBS.BLL.BBSTopic bll=new BBS.BLL.BBSTopic();
		BBS.Model.BBSTopic model=bll.GetModel(tid);
		this.lbltid.Text=model.tid.ToString();
		this.txttsid.Text=model.tsid.ToString();
		this.txttuid.Text=model.tuid.ToString();
		this.txttreplycount.Text=model.treplycount.ToString();
		this.txtTTopic.Text=model.TTopic;
		this.txtTContents.Text=model.TContents;
		this.txtTTime.Text=model.TTime.ToString();
		this.txtTClickCount.Text=model.TClickCount.ToString();
		this.txtTLastClickT.Text=model.TLastClickT.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
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
			int tid=int.Parse(this.lbltid.Text);
			int tsid=int.Parse(this.txttsid.Text);
			int tuid=int.Parse(this.txttuid.Text);
			int treplycount=int.Parse(this.txttreplycount.Text);
			string TTopic=this.txtTTopic.Text;
			string TContents=this.txtTContents.Text;
			DateTime TTime=DateTime.Parse(this.txtTTime.Text);
			int TClickCount=int.Parse(this.txtTClickCount.Text);
			DateTime TLastClickT=DateTime.Parse(this.txtTLastClickT.Text);


			BBS.Model.BBSTopic model=new BBS.Model.BBSTopic();
			model.tid=tid;
			model.tsid=tsid;
			model.tuid=tuid;
			model.treplycount=treplycount;
			model.TTopic=TTopic;
			model.TContents=TContents;
			model.TTime=TTime;
			model.TClickCount=TClickCount;
			model.TLastClickT=TLastClickT;

			BBS.BLL.BBSTopic bll=new BBS.BLL.BBSTopic();
			bll.Update(model);
			Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
