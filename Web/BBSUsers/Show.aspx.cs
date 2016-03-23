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
namespace BBS.Web.BBSUsers
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
					int Uid=(Convert.ToInt32(strid));
					ShowInfo(Uid);
				}
			}
		}
		
	private void ShowInfo(int Uid)
	{
		BBS.BLL.BBSUsers bll=new BBS.BLL.BBSUsers();
		BBS.Model.BBSUsers model=bll.GetModel(Uid);
		this.lblUid.Text=model.Uid.ToString();
		this.lblUname.Text=model.Uname;
		this.lblUPassword.Text=model.UPassword;
		this.lblUEmail.Text=model.UEmail;
		this.lblUBirthday.Text=model.UBirthday.ToString();
		this.lblUsex.Text=model.Usex?"是":"否";
		this.lblUClass.Text=model.UClass.ToString();
		this.lblUStatement.Text=model.UStatement;
		this.lblURegDate.Text=model.URegDate.ToString();
		this.lblUState.Text=model.UState.ToString();
		this.lblUPoint.Text=model.UPoint.ToString();

	}


    }
}
