using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
namespace Web.WEB.ashx
{
    /// <summary>
    /// Summary description for CommentList
    /// </summary>
    public class CommentList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            String str = string.Empty;

            if (context.Request["pageIndex"] != null && context.Request["pageIndex"].ToString().Length > 0)
            {
                int pageIndex;   //具体的页面数
                string sqlwhere = context.Request["sqlwhere"];
                int.TryParse(context.Request["pageIndex"], out pageIndex);
                if (context.Request["pageSize"] != null && context.Request["pageSize"].ToString().Length > 0)
                {
                    //页面显示条数   
                    int size = Convert.ToInt32(context.Request["pageSize"]);
                    string data = BindSource(size, pageIndex, sqlwhere);
                    context.Response.Write(data);
                    context.Response.End();
                }
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        public string BindSource(int pagesize, int page, string sqlwhere)
        {
            BBS.BLL.BBSReply bll = new BBS.BLL.BBSReply();
            //获取分页数据
            DataSet ds = bll.GetListByPage(sqlwhere, "", pagesize * page + 1, pagesize * (page + 1));  //获取数据源的ds会吧。
            ds.Tables[0].TableName = "List";
            return Web.DataConvertJson.DataTable2Json(ds.Tables[0]);
        }
    }
}