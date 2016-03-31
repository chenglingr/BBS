using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Net;
using System.IO;

namespace Web
{
    public partial class Index1 : System.Web.UI.Page
    {
        public string pageCount = string.Empty; //总条目数
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string url = "SupplyAJAX.aspx";
                string strResult = GetRequestJsonString(url, "type=getcount");
                pageCount = strResult.ToString();
            }
        }
        #region 后台获取ashx返回的数据
        /// <summary>
        /// 后台获取ashx返回的数据
        /// </summary>
        /// <param name="relativePath">地址</param>
        /// <param name="data">参数</param>
        /// <returns></returns>
        public static string GetRequestJsonString(string relativePath, string data)
        {
            string requestUrl = GetRequestUrl(relativePath, data);

            try
            {
                WebRequest request = WebRequest.Create(requestUrl);
                request.Method = "GET";

                StreamReader jsonStream = new StreamReader(request.GetResponse().GetResponseStream());
                string jsonObject = jsonStream.ReadToEnd();

                return jsonObject;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string GetRequestUrl(string relativePath, string data)
        {
            string absolutePath = HttpContext.Current.Request.Url.AbsoluteUri;
            string hostNameAndPort = HttpContext.Current.Request.Url.Authority;
            string applicationDir = HttpContext.Current.Request.ApplicationPath;
            StringBuilder sbRequestUrl = new StringBuilder();
            sbRequestUrl.Append(absolutePath.Substring(0, absolutePath.IndexOf(hostNameAndPort)));
            sbRequestUrl.Append(hostNameAndPort);
            sbRequestUrl.Append(applicationDir);
            sbRequestUrl.Append(relativePath);
            if (!string.IsNullOrEmpty(data))
            {
                sbRequestUrl.Append("?");
                sbRequestUrl.Append(data);
            }
            return sbRequestUrl.ToString();
        }
        #endregion
    }
}
