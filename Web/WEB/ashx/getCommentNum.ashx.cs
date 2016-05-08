using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for getCommentNum
    /// </summary>
    public class getCommentNum : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string sqlwhere = context.Request["sqlwhere"];
            string json = "{'info':'0'}";

            BBS.BLL.BBSReply bll = new BBS.BLL.BBSReply();
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