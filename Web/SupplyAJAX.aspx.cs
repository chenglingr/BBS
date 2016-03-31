using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Text;
using System.Data;
namespace Web
{
    public partial class SupplyAJAX : System.Web.UI.Page
    {
        protected static List<Student> StudentList = new List<Student>();
        protected static int RecordCount = 0;
        protected static DataTable dt = CreateDT();

        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request["type"])
            {
                case "show":
                    #region 分页配置
                    //具体的页面数
                    int pageIndex;
                    int.TryParse(Request["pageIndex"], out pageIndex);
                    //页面显示条数
                    int PageSize = Convert.ToInt32(Request["pageSize"]);
                    if (pageIndex == 0)
                    {
                        pageIndex = 1;
                    }
                    #endregion
                    DataTable PagedDT = GetPagedTable(dt, pageIndex, PageSize);
                    List<Student> list = new List<Student>();
                    foreach (DataRow dr in PagedDT.Rows)
                    {
                        Student c = new Student();
                        c.Id = (Int32)dr["Id"];
                        c.Name = dr["Name"].ToString();
                        c.Sex = dr["Sex"].ToString();
                        list.Add(c);
                    }
                    string json = new JavaScriptSerializer().Serialize(list);//这个很关键，否则error 
                    StringBuilder Builder = new StringBuilder();
                    Builder.Append("{");
                    Builder.Append("\"recordcount\":" + RecordCount + ",");
                    Builder.Append("\"data\":");
                    Builder.Append(json);
                    Builder.Append("}");
                    Response.ContentType = "application/json";
                    Response.Write(Builder.ToString());
                    break;
                case "getcount":
                    Response.Write(dt.Rows.Count);
                    break;
                case "add":
                    break;
                case "update":
                    break;
                case "delete":
                    break;
            }
            Response.End();
        }

        #region 模拟数据
        private static DataTable CreateDT()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Id", typeof(int)) { DefaultValue = 0 });
            dt.Columns.Add(new DataColumn("Name", typeof(string)) { DefaultValue = "1" });
            dt.Columns.Add(new DataColumn("Sex", typeof(string)) { DefaultValue = "男" });
            for (int i = 1; i <= 1000; i++)
            {
                dt.Rows.Add(i, "张三" + i.ToString().PadLeft(4, '0'));
            }
            RecordCount = dt.Rows.Count;
            return dt;
        }
        #endregion

        /// <summary>  
        /// 对DataTable进行分页,起始页为1  
        /// </summary>  
        /// <param name="dt"></param>  
        /// <param name="PageIndex"></param>  
        /// <param name="PageSize"></param>  
        /// <returns></returns>  
        public static DataTable GetPagedTable(DataTable dt, int PageIndex, int PageSize)
        {
            if (PageIndex == 0)
                return dt;
            DataTable newdt = dt.Copy();
            newdt.Clear();
            int rowbegin = (PageIndex - 1) * PageSize;
            int rowend = PageIndex * PageSize;
            if (rowbegin >= dt.Rows.Count)
                return newdt;
            if (rowend > dt.Rows.Count)
                rowend = dt.Rows.Count;
            for (int i = rowbegin; i <= rowend - 1; i++)
            {
                DataRow newdr = newdt.NewRow();
                DataRow dr = dt.Rows[i];
                foreach (DataColumn column in dt.Columns)
                {
                    newdr[column.ColumnName] = dr[column.ColumnName];
                }
                newdt.Rows.Add(newdr);
            }
            return newdt;
        }

        /// <summary>  
        /// 获取总页数  
        /// </summary>  
        /// <param name="sumCount">结果集数量</param>  
        /// <param name="pageSize">页面数量</param>  
        /// <returns></returns>  
        public static int getPageCount(int sumCount, int pageSize)
        {
            int page = sumCount / pageSize;
            if (sumCount % pageSize > 0)
            {
                page = page + 1;
            }
            return page;
        }


        public struct Student
        {
            public int Id;
            public string Name;
            public string Sex;
        }
    }
}