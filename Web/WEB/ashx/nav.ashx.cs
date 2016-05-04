using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for nav
    /// </summary>
    public class nav : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string action = context.Request.Form["Action"];
            string json = "{}";
            if (action == "Load")
            {
                if (context.Session["ID"] != null)
                {
                    json = "{\"info\":\""+context.Session["Name"]+"\"}";
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