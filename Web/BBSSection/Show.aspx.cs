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
namespace BBS.Web.BBSSection
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
					int SID=(Convert.ToInt32(strid));
					ShowInfo(SID);
				}
			}
		}
		
	private void ShowInfo(int SID)
	{
		BBS.BLL.BBSSection bll=new BBS.BLL.BBSSection();
		BBS.Model.BBSSection model=bll.GetModel(SID);
		this.lblSID.Text=model.SID.ToString();
		this.lblSName.Text=model.SName;
		this.lblSMasterID.Text=model.SMasterID.ToString();
		this.lblSStatement.Text=model.SStatement;
		this.lblSClickCount.Text=model.SClickCount.ToString();
		this.lblSTopicCount.Text=model.STopicCount.ToString();

	}


    }
}
