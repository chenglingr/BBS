using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for Category
    /// </summary>
    public class Category : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string json = "{}";
            string action = context.Request.Form["Action"];

            if (action == "Show")
            {

                BBS.BLL.BBSSection bll = new BBS.BLL.BBSSection();
                DataSet ds = bll.GetList("");//获取版块列表
                ds.Tables[0].TableName = "CategoryList";//修改数据表的名字


                //返回列表
                json = Web.DataConvertJson.DataTable2Json(ds.Tables[0]);//转换


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