using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for ARList
    /// </summary>
    public class ARList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string json = "{}";
            string action = context.Request.Form["Action"];

            int uid=   int.Parse(context.Request["UID"]);

            int displayStart = int.Parse(context.Request["offset"]);//起始页
            int displayLength = int.Parse(context.Request["limit"]);//每页数量
            string strwhere = "";
            if (uid != 0) { strwhere = "tuid=" + uid; }

            BBS.BLL.BBSTopic bll = new BBS.BLL.BBSTopic();
            int total = bll.GetRecordCount(strwhere);
            DataSet ds = bll.GetListByPage(strwhere, "", displayStart + 1, displayStart + displayLength);
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