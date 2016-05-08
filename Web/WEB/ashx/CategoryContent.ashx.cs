using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for CategoryContent
    /// </summary>
    public class CategoryContent : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";


            context.Response.Write("Hello World");
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