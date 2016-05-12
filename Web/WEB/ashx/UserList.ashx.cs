using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Web.WEB.ashx
{
    /// <summary>
    /// UserList 的摘要说明
    /// </summary>
    public class UserList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string json = "{}";
            string action = context.Request.Form["Action"];

            int displayStart = int.Parse(context.Request["offset"]);
            int displayLength = int.Parse(context.Request["limit"]);

            BBS.BLL.BBSUsers bll = new BBS.BLL.BBSUsers();
            int total = bll.GetRecordCount("");
            DataSet ds = bll.GetListByPage("", "", displayStart + 1, displayStart + displayLength);
            ds.Tables[0].TableName = "rows";
            //返回列表
            json = Web.DataConvertJson.DataTable2Json(ds.Tables[0]);
           
            //??服务器端返回的数据中还要包括rows，total（数据总量）两个字段，前端要根据这两个字段分页。
            json = "{\"total\":" + total + "," + json.Substring(1);

            /*
             返回数据格式
             {"total":100,"rows":....}
             
             */

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