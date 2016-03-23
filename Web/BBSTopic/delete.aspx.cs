using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BBS.Web.BBSTopic
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				BBS.BLL.BBSTopic bll=new BBS.BLL.BBSTopic();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int tid=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(tid);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}