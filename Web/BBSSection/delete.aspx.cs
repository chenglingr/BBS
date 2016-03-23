using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BBS.Web.BBSSection
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				BBS.BLL.BBSSection bll=new BBS.BLL.BBSSection();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int SID=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(SID);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}