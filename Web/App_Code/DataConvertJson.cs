using System;
using System.Collections.Generic;

using System.Web;
using System.Text;
using System.Data;
using System.Web.Script.Serialization;//添加本引用。

namespace Web
{

    /// <summary>
    /// DataTableConvertJson 的摘要说明
    /// </summary>
    public class DataConvertJson
    {
        /// <summary>
        /// 把对象转成json字符串
        /// </summary>
        /// <param name="o">对象</param>
        /// <returns>json字符串</returns>
        public static string NewsObjectToJSON(object model)
        {
          
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string jsonString = serializer.Serialize(model);
            return jsonString;
        }

        public static string NewsObjectToJSON(object o, string jsonName)
        {

            StringBuilder Json = new StringBuilder();
            Json.Append("{\"" + jsonName + "\":[");
            Json.Append("{");
            System.Reflection.PropertyInfo[] properties = o.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (System.Reflection.PropertyInfo item in properties)
            {
                string name = item.Name;
                object value = item.GetValue(o, null);
                //  string s = (value.ToString()).Replace("\\", "\\\\"); //斜杠
                string s = (value.ToString()).Replace("\\", "\\\\").Replace("\'", "\\\'").Replace("\t", " ").Replace("\r", " ").Replace("\n", "<br/>").Replace("\"", "'");
                Json.Append("\"" + name + "\":\"" + s + "\"");
                Json.Append(",");
            }
            Json = Json.Remove(Json.Length - 1, 1);
            Json.Append("}");


            Json.Append("]}");
            return Json.ToString();
        }
        #region dataTable转换成Json格式
        /// <summary>  
        /// dataTable转换成Json格式  
        /// </summary>  
        /// <param name="dt"></param>  
        /// <returns></returns>  
        public static string DataTable2Json(DataTable dt)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("{\"");
            jsonBuilder.Append(dt.TableName);
            jsonBuilder.Append("\":[");
          //  jsonBuilder.Append("[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName);
                    jsonBuilder.Append("\":\"");
                    //    jsonBuilder.Append(dt.Rows[i][j].ToString().Replace("\\", "\\\\")); 特殊字符
                    jsonBuilder.Append(dt.Rows[i][j].ToString().Replace("\\", "\\\\").Replace("\'", "\\\'").Replace("\t", " ").Replace("\r", " ").Replace("\n", "<br/>").Replace("\"", "'"));
                    jsonBuilder.Append("\",");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("},");
            }
            jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("]");
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        #endregion dataTable转换成Json格式
        #region DataSet转换成Json格式
        /// <summary>  
        /// DataSet转换成Json格式  
        /// </summary>  
        /// <param name="ds">DataSet</param> 
        /// <returns></returns>  
        public static string Dataset2Json(DataSet ds)
        {
            StringBuilder json = new StringBuilder();

            foreach (DataTable dt in ds.Tables)
            {
                string ss = DataTable2Json(dt);
                ss= ss.Remove(0, 1);
                json.Append(ss);
                json.Remove(json.Length - 1,1);
                json.Append(",");
             
            }
            if (json.Length > 0)
            {
                json.Insert(0, "{");
                json.Remove(json.Length - 1, 1);
                json.Append("}");
            }
            return json.ToString();
        }
        #endregion

        /// <summary>
        /// Msdn
        /// </summary>
        /// <param name="jsonName"></param>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string DataTableToJson(string jsonName, DataTable dt)
        {
            StringBuilder Json = new StringBuilder();
            Json.Append("{\"" + jsonName + "\":[");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Json.Append("{");
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        Json.Append("\"" + dt.Columns[j].ColumnName.ToString() + "\":\"" + dt.Rows[i][j].ToString().Replace("\\", "\\\\") + "\"");
                        if (j < dt.Columns.Count - 1)
                        {
                            Json.Append(",");
                        }
                    }
                    Json.Append("}");
                    if (i < dt.Rows.Count - 1)
                    {
                        Json.Append(",");
                    }
                }
            }
            Json.Append("]}");
            return Json.ToString();
        }
       
    }
}