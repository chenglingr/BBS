using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BBS.IDAL;
using DBUtility;//Please add references
namespace BBS.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:BBSTopic
	/// </summary>
	public partial class BBSTopic:IBBSTopic
	{
		public BBSTopic()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("tid", "BBSTopic"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int tid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BBSTopic");
			strSql.Append(" where tid="+tid+" ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BBS.Model.BBSTopic model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.tsid != null)
			{
				strSql1.Append("tsid,");
				strSql2.Append(""+model.tsid+",");
			}
			if (model.tuid != null)
			{
				strSql1.Append("tuid,");
				strSql2.Append(""+model.tuid+",");
			}
			if (model.treplycount != null)
			{
				strSql1.Append("treplycount,");
				strSql2.Append(""+model.treplycount+",");
			}
			if (model.TTopic != null)
			{
				strSql1.Append("TTopic,");
				strSql2.Append("'"+model.TTopic+"',");
			}
			if (model.TContents != null)
			{
				strSql1.Append("TContents,");
				strSql2.Append("'"+model.TContents+"',");
			}
			if (model.TTime != null)
			{
				strSql1.Append("TTime,");
				strSql2.Append("'"+model.TTime+"',");
			}
			if (model.TClickCount != null)
			{
				strSql1.Append("TClickCount,");
				strSql2.Append(""+model.TClickCount+",");
			}
			if (model.TLastClickT != null)
			{
				strSql1.Append("TLastClickT,");
				strSql2.Append("'"+model.TLastClickT+"',");
			}
			strSql.Append("insert into BBSTopic(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			strSql.Append(";select @@IDENTITY");
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(BBS.Model.BBSTopic model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BBSTopic set ");
			if (model.tsid != null)
			{
				strSql.Append("tsid="+model.tsid+",");
			}
			if (model.tuid != null)
			{
				strSql.Append("tuid="+model.tuid+",");
			}
			if (model.treplycount != null)
			{
				strSql.Append("treplycount="+model.treplycount+",");
			}
			if (model.TTopic != null)
			{
				strSql.Append("TTopic='"+model.TTopic+"',");
			}
			if (model.TContents != null)
			{
				strSql.Append("TContents='"+model.TContents+"',");
			}
			if (model.TTime != null)
			{
				strSql.Append("TTime='"+model.TTime+"',");
			}
			if (model.TClickCount != null)
			{
				strSql.Append("TClickCount="+model.TClickCount+",");
			}
			if (model.TLastClickT != null)
			{
				strSql.Append("TLastClickT='"+model.TLastClickT+"',");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where tid="+ model.tid+"");
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int tid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BBSTopic ");
			strSql.Append(" where tid="+tid+"" );
			int rowsAffected=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string tidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BBSTopic ");
			strSql.Append(" where tid in ("+tidlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BBS.Model.BBSTopic GetModel(int tid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" tid,tsid,tuid,treplycount,TTopic,TContents,TTime,TClickCount,TLastClickT ");
			strSql.Append(" from BBSTopic ");
			strSql.Append(" where tid="+tid+"" );
			BBS.Model.BBSTopic model=new BBS.Model.BBSTopic();
			DataSet ds=DbHelperSQL.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BBS.Model.BBSTopic DataRowToModel(DataRow row)
		{
			BBS.Model.BBSTopic model=new BBS.Model.BBSTopic();
			if (row != null)
			{
				if(row["tid"]!=null && row["tid"].ToString()!="")
				{
					model.tid=int.Parse(row["tid"].ToString());
				}
				if(row["tsid"]!=null && row["tsid"].ToString()!="")
				{
					model.tsid=int.Parse(row["tsid"].ToString());
				}
				if(row["tuid"]!=null && row["tuid"].ToString()!="")
				{
					model.tuid=int.Parse(row["tuid"].ToString());
				}
				if(row["treplycount"]!=null && row["treplycount"].ToString()!="")
				{
					model.treplycount=int.Parse(row["treplycount"].ToString());
				}
				if(row["TTopic"]!=null)
				{
					model.TTopic=row["TTopic"].ToString();
				}
				if(row["TContents"]!=null)
				{
					model.TContents=row["TContents"].ToString();
				}
				if(row["TTime"]!=null && row["TTime"].ToString()!="")
				{
					model.TTime=DateTime.Parse(row["TTime"].ToString());
				}
				if(row["TClickCount"]!=null && row["TClickCount"].ToString()!="")
				{
					model.TClickCount=int.Parse(row["TClickCount"].ToString());
				}
				if(row["TLastClickT"]!=null && row["TLastClickT"].ToString()!="")
				{
					model.TLastClickT=DateTime.Parse(row["TLastClickT"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select tid,tsid,tuid,treplycount,TTopic,TContents,TTime,TClickCount,TLastClickT ");
			strSql.Append(" FROM BBSTopic ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" tid,tsid,tuid,treplycount,TTopic,TContents,TTime,TClickCount,TLastClickT ");
			strSql.Append(" FROM BBSTopic ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM BBSTopic ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.tid desc");
			}
			strSql.Append(")AS Row, T.*  from BBSTopic T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

