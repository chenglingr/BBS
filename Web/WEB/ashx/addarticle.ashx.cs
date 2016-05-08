using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for addarticle
    /// </summary>
    public class addarticle : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            //  context.Response.ContentType = "text/plain";
          
            context.Response.ContentType = "text/html";
            string action = context.Request.Form["Action"];
            string json = "{\"info\":\"已登录\"}";
            if (action == "Load")
            {
                if (context.Session["ID"] == null)
                {
                    json = "{\"info\":\"未登录\"}";
                }
                else
                {
                    BBS.BLL.BBSSection bll0 = new BBS.BLL.BBSSection();
                    DataSet ds = bll0.GetList("");
                    ds.Tables[0].TableName = "BBSSection";
                    string   json1 = Web.DataConvertJson.DataTable2Json(ds.Tables[0]);
                    json = "{\"info\":\"已登录\"," + json1.Substring(1);
                }

            }
            else if(action == "Add")
            {
                json = "{\"info\":\"发表失败\"}";

                string content = context.Request.Form["Content"]; //保存文本框对象，提高效率
                content = HttpContext.Current.Server.UrlDecode(content);//反编码
              
             

                int tsid = int.Parse( context.Request.Form["section"]);
                int tuid = int.Parse(context.Session["ID"].ToString());
                int treplycount = 0;
                string TTopic = context.Request.Form["title"];
                string TContents = content;
                DateTime TTime = DateTime.Now;
                int TClickCount = 0;
                DateTime TLastClickT = DateTime.Now;

                BBS.Model.BBSTopic model = new BBS.Model.BBSTopic();
                model.tsid = tsid;
                model.tuid = tuid;
                model.treplycount = treplycount;
                model.TTopic = TTopic;
                model.TContents = TContents;
                model.TTime = TTime;
                model.TClickCount = TClickCount;
                model.TLastClickT = TLastClickT;
         
                BBS.BLL.BBSTopic bll = new BBS.BLL.BBSTopic();
                int n = bll.Add(model);
                //返回单个文字信息
                if (n > 0)
                {
                    json = "{\"info\":\"增加数据成功\"}";
                 
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