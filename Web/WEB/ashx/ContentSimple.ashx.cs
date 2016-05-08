using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for ContentSimple
    /// </summary>
    public class ContentSimple : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string ID = context.Request.Form["ID"];
            BBS.BLL.BBSTopic bll = new BBS.BLL.BBSTopic();
            // Model.Admin前必须加 [Serializable]
            BBS.Model.BBSTopic model = bll.GetModel(int.Parse(ID));
            //返回一个类的对象
            string jsonString;
            if (model == null) { jsonString = "{}"; }
            else
            { 
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                jsonString = serializer.Serialize(model);
            }
            context.Response.Write(jsonString);
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