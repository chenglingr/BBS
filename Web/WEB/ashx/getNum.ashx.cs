using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for getNum
    /// </summary>
    public class getNum : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string sqlwhere = context.Request["sqlwhere"];
            string json = "{'info':'0'}";

            BBS.BLL.BBSTopic bll = new BBS.BLL.BBSTopic();
            int n = bll.GetRecordCount(sqlwhere);
            json = "{'info':'" + n + "'}";
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