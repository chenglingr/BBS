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
namespace BBS.Web.BBSTopic
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int tid=(Convert.ToInt32(strid));
					ShowInfo(tid);
				}
			}
		}
		
	private void ShowInfo(int tid)
	{
		BBS.BLL.BBSTopic bll=new BBS.BLL.BBSTopic();
		BBS.Model.BBSTopic model=bll.GetModel(tid);
		this.lbltid.Text=model.tid.ToString();
		this.lbltsid.Text=model.tsid.ToString();
		this.lbltuid.Text=model.tuid.ToString();
		this.lbltreplycount.Text=model.treplycount.ToString();
		this.lblTTopic.Text=model.TTopic;
		this.lblTContents.Text=model.TContents;
		this.lblTTime.Text=model.TTime.ToString();
		this.lblTClickCount.Text=model.TClickCount.ToString();
		this.lblTLastClickT.Text=model.TLastClickT.ToString();

	}


    }
}
