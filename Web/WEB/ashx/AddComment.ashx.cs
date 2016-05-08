using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for AddComment
    /// </summary>
    public class AddComment : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

          
            string json = "{}";

            if (context.Session["ID"] != null)
            {
               
                int RTID = int.Parse(context.Request.Form["TID"]);
                int RSID =1;
                int RUID = int.Parse(context.Session["ID"].ToString());
                string RTopic = context.Request.Form["title"];;
                string RContents =context.Request.Form["content"];;
                DateTime RTime = DateTime.Now;
                int RClickCount = 0;

                BBS.Model.BBSReply model = new BBS.Model.BBSReply();
                model.RTID = RTID;
                model.RSID = RSID;
                model.RUID = RUID;
                model.RTopic = RTopic;
                model.RContents = RContents;
                model.RTime = RTime;
                model.RClickCount = RClickCount;

                BBS.BLL.BBSReply bll = new BBS.BLL.BBSReply();
                int n=  bll.Add(model);
                if (n > 0) { json = "{\"info\":\"增加数据失败\"}"; }
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