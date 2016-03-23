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

namespace BBS.Web.BBSUsers
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Uid=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Uid);
				}
			}
		}
			
	private void ShowInfo(int Uid)
	{
		BBS.BLL.BBSUsers bll=new BBS.BLL.BBSUsers();
		BBS.Model.BBSUsers model=bll.GetModel(Uid);
		this.lblUid.Text=model.Uid.ToString();
		this.txtUname.Text=model.Uname;
		this.txtUPassword.Text=model.UPassword;
		this.txtUEmail.Text=model.UEmail;
		this.txtUBirthday.Text=model.UBirthday.ToString();
		this.chkUsex.Checked=model.Usex;
		this.txtUClass.Text=model.UClass.ToString();
		this.txtUStatement.Text=model.UStatement;
		this.txtURegDate.Text=model.URegDate.ToString();
		this.txtUState.Text=model.UState.ToString();
		this.txtUPoint.Text=model.UPoint.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUname.Text.Trim().Length==0)
			{
				strErr+="Uname不能为空！\\n";	
			}
			if(this.txtUPassword.Text.Trim().Length==0)
			{
				strErr+="UPassword不能为空！\\n";	
			}
			if(this.txtUEmail.Text.Trim().Length==0)
			{
				strErr+="UEmail不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtUBirthday.Text))
			{
				strErr+="UBirthday格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUClass.Text))
			{
				strErr+="UClass格式错误！\\n";	
			}
			if(this.txtUStatement.Text.Trim().Length==0)
			{
				strErr+="UStatement不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtURegDate.Text))
			{
				strErr+="URegDate格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUState.Text))
			{
				strErr+="UState格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUPoint.Text))
			{
				strErr+="UPoint格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Uid=int.Parse(this.lblUid.Text);
			string Uname=this.txtUname.Text;
			string UPassword=this.txtUPassword.Text;
			string UEmail=this.txtUEmail.Text;
			DateTime UBirthday=DateTime.Parse(this.txtUBirthday.Text);
			bool Usex=this.chkUsex.Checked;
			int UClass=int.Parse(this.txtUClass.Text);
			string UStatement=this.txtUStatement.Text;
			DateTime URegDate=DateTime.Parse(this.txtURegDate.Text);
			int UState=int.Parse(this.txtUState.Text);
			int UPoint=int.Parse(this.txtUPoint.Text);


			BBS.Model.BBSUsers model=new BBS.Model.BBSUsers();
			model.Uid=Uid;
			model.Uname=Uname;
			model.UPassword=UPassword;
			model.UEmail=UEmail;
			model.UBirthday=UBirthday;
			model.Usex=Usex;
			model.UClass=UClass;
			model.UStatement=UStatement;
			model.URegDate=URegDate;
			model.UState=UState;
			model.UPoint=UPoint;

			BBS.BLL.BBSUsers bll=new BBS.BLL.BBSUsers();
			bll.Update(model);
			Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
