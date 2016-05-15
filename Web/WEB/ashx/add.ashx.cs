using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for add
    /// </summary>
    public class add : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string json = "{'info':'增加数据失败'}";

            //获取GET方法传递参数：Request.QueryString["参数名称"];
            //获取POST方法传递参数：Request.Form["参数名称"];

            string action = context.Request.Form["Action"];

            if (action == "Add")
            {
                string uname = context.Request.Form["uname"]; //保存文本框对象，提高效率
                string upassword = context.Request.Form["upassword"];
                string uemail = context.Request.Form["uemail"];
                string ubirthday = context.Request.Form["ubirthday"];
                string ustatement = context.Request.Form["ustatement"];
                string usex = context.Request.Form["usex"];
          
              

                BBS.Model.BBSUsers model = new BBS.Model.BBSUsers();
                model.Uname = uname;
                model.UPassword = upassword;
                model.UEmail = uemail;
                model.UBirthday =DateTime.Parse( ubirthday);
                model.UStatement = ustatement;
                model.Usex = false;
                if (usex == "true") { model.Usex = true; }
                
                BBS.BLL.BBSUsers bll = new BBS.BLL.BBSUsers();
                int n = bll.Add(model);
                //返回单个文字信息
                if (n > 0)
                {
                    json = "{'info':'增加数据成功,编号是：" + n + "'}";
                    context.Session["ID"] = n;
                    context.Session["Name"] = uname;
                }
            }
          

            context.Response.Write(json);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}