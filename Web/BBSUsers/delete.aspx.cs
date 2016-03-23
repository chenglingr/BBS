using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BBS.Web.BBSUsers
{
    public partial class delete : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            			if (!Page.IsPostBack)
			{
				BBS.BLL.BBSUsers bll=new BBS.BLL.BBSUsers();
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Uid=(Convert.ToInt32(Request.Params["id"]));
					bll.Delete(Uid);
					Response.Redirect("list.aspx");
				}
			}

        }
    }
}