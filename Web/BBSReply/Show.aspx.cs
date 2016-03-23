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
namespace BBS.Web.BBSReply
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
					int RID=(Convert.ToInt32(strid));
					ShowInfo(RID);
				}
			}
		}
		
	private void ShowInfo(int RID)
	{
		BBS.BLL.BBSReply bll=new BBS.BLL.BBSReply();
		BBS.Model.BBSReply model=bll.GetModel(RID);
		this.lblRID.Text=model.RID.ToString();
		this.lblRTID.Text=model.RTID.ToString();
		this.lblRSID.Text=model.RSID.ToString();
		this.lblRUID.Text=model.RUID.ToString();
		this.lblRTopic.Text=model.RTopic;
		this.lblRContents.Text=model.RContents;
		this.lblRTime.Text=model.RTime.ToString();
		this.lblRClickCount.Text=model.RClickCount.ToString();

	}


    }
}
