using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for index
    /// </summary>
    public class index : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string json = "{}";
            string action = context.Request.Form["Action"];

            if (action == "Show")
            {

                BBS.BLL.BBSTopic bll = new BBS.BLL.BBSTopic();
                DataSet ds = bll.GetList(10,"", "TClickCount");//获取点击率最高的
                ds.Tables[0].TableName = "hotArticles";//修改数据表的名字

               
                DataSet dstop5 = bll.GetList(10,"", "TTime");//获取最新的

                DataTable top5 = dstop5.Tables[0].Copy();//获取数据表
                top5.TableName = "newArticles"; //改名
                ds.Tables.Add(top5);//把前5个用户的数据表，加到数据集ds中

                //返回列表
                json = Web.DataConvertJson.Dataset2Json(ds);//转换


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