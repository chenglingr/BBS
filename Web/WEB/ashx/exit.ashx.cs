using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for exit
    /// </summary>
    public class exit : IHttpHandler, System.Web.SessionState.IRequiresSessionState  //实现此接口
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Session["ID"] = null;//清空session
            context.Response.Redirect("../index.html");
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