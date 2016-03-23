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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			bll.Add(model);
			Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
