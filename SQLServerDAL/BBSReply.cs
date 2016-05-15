﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BBS.IDAL;
using DBUtility;//Please add references
namespace BBS.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:BBSReply
	/// </summary>
	public partial class BBSReply:IBBSReply
	{
		public BBSReply()
		{ }
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("RID", "BBSReply"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int RID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BBSReply");
			strSql.Append(" where RID="+RID+" ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BBS.Model.BBSReply model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.RTID != null)
			{
				strSql1.Append("RTID,");
				strSql2.Append(""+model.RTID+",");
			}
			if (model.RSID != null)
			{
				strSql1.Append("RSID,");
				strSql2.Append(""+model.RSID+",");
			}
			if (model.RUID != null)
			{
				strSql1.Append("RUID,");
				strSql2.Append(""+model.RUID+",");
			}
			if (model.RTopic != null)
			{
				strSql1.Append("RTopic,");
				strSql2.Append("'"+model.RTopic+"',");
			}
			if (model.RContents != null)
			{
				strSql1.Append("RContents,");
				strSql2.Append("'"+model.RContents+"',");
			}
			if (model.RTime != null)
			{
				strSql1.Append("RTime,");
				strSql2.Append("'"+model.RTime+"',");
			}
			if (model.RClickCount != null)
			{
				strSql1.Append("RClickCount,");
				strSql2.Append(""+model.RClickCount+",");
			}
			strSql.Append("insert into BBSReply(");
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
                //更新帖子表里回复数
                string sqlupdateReplyCount = string.Format("update BBSTopic set treplycount=treplycount+1 where tid={0}", model.RTID);
                DbHelperSQL.ExecuteSql(sqlupdateReplyCount);//更新
                return Convert.ToInt32(obj);
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(BBS.Model.BBSReply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BBSReply set ");
			if (model.RTID != null)
			{
				strSql.Append("RTID="+model.RTID+",");
			}
			else
			{
				strSql.Append("RTID= null ,");
			}
			if (model.RSID != null)
			{
				strSql.Append("RSID="+model.RSID+",");
			}
			else
			{
				strSql.Append("RSID= null ,");
			}
			if (model.RUID != null)
			{
				strSql.Append("RUID="+model.RUID+",");
			}
			else
			{
				strSql.Append("RUID= null ,");
			}
			if (model.RTopic != null)
			{
				strSql.Append("RTopic='"+model.RTopic+"',");
			}
			else
			{
				strSql.Append("RTopic= null ,");
			}
			if (model.RContents != null)
			{
				strSql.Append("RContents='"+model.RContents+"',");
			}
			else
			{
				strSql.Append("RContents= null ,");
			}
			if (model.RTime != null)
			{
				strSql.Append("RTime='"+model.RTime+"',");
			}
			else
			{
				strSql.Append("RTime= null ,");
			}
			if (model.RClickCount != null)
			{
				strSql.Append("RClickCount="+model.RClickCount+",");
			}
			else
			{
				strSql.Append("RClickCount= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where RID="+ model.RID+"");
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
		public bool Delete(int RID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BBSReply ");
			strSql.Append(" where RID="+RID+"" );
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
		public bool DeleteList(string RIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BBSReply ");
			strSql.Append(" where RID in ("+RIDlist + ")  ");
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
		public BBS.Model.BBSReply GetModel(int RID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" RID,RTID,RSID,RUID,RTopic,RContents,RTime,RClickCount ");
			strSql.Append(" from BBSReply ");
			strSql.Append(" where RID="+RID+"" );
			BBS.Model.BBSReply model=new BBS.Model.BBSReply();
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
		public BBS.Model.BBSReply DataRowToModel(DataRow row)
		{
			BBS.Model.BBSReply model=new BBS.Model.BBSReply();
			if (row != null)
			{
				if(row["RID"]!=null && row["RID"].ToString()!="")
				{
					model.RID=int.Parse(row["RID"].ToString());
				}
				if(row["RTID"]!=null && row["RTID"].ToString()!="")
				{
					model.RTID=int.Parse(row["RTID"].ToString());
				}
				if(row["RSID"]!=null && row["RSID"].ToString()!="")
				{
					model.RSID=int.Parse(row["RSID"].ToString());
				}
				if(row["RUID"]!=null && row["RUID"].ToString()!="")
				{
					model.RUID=int.Parse(row["RUID"].ToString());
				}
				if(row["RTopic"]!=null)
				{
					model.RTopic=row["RTopic"].ToString();
				}
				if(row["RContents"]!=null)
				{
					model.RContents=row["RContents"].ToString();
				}
				if(row["RTime"]!=null && row["RTime"].ToString()!="")
				{
					model.RTime=DateTime.Parse(row["RTime"].ToString());
				}
				if(row["RClickCount"]!=null && row["RClickCount"].ToString()!="")
				{
					model.RClickCount=int.Parse(row["RClickCount"].ToString());
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
			strSql.Append("select RID,RTID,RSID,RUID,RTopic,RContents,RTime,RClickCount ");
			strSql.Append(" FROM BBSReply ");
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
			strSql.Append(" RID,RTID,RSID,RUID,RTopic,RContents,RTime,RClickCount ");
			strSql.Append(" FROM BBSReply ");
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
			strSql.Append("select count(1) FROM BBSReply ");
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
				strSql.Append("order by T.RID desc");
			}
			strSql.Append(")AS Row, T.*  from BBSReply T ");
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

