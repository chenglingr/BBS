using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BBS.IDAL;
using DBUtility;//Please add references
namespace BBS.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:BBSUsers
	/// </summary>
	public partial class BBSUsers:IBBSUsers
	{
		public BBSUsers()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Uid", "BBSUsers"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Uid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BBSUsers");
			strSql.Append(" where Uid="+Uid+" ");
			return DbHelperSQL.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(BBS.Model.BBSUsers model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.Uname != null)
			{
				strSql1.Append("Uname,");
				strSql2.Append("'"+model.Uname+"',");
			}
			if (model.UPassword != null)
			{
				strSql1.Append("UPassword,");
				strSql2.Append("'"+model.UPassword+"',");
			}
			if (model.UEmail != null)
			{
				strSql1.Append("UEmail,");
				strSql2.Append("'"+model.UEmail+"',");
			}
			if (model.UBirthday != null)
			{
				strSql1.Append("UBirthday,");
				strSql2.Append("'"+model.UBirthday+"',");
			}
			if (model.Usex != null)
			{
				strSql1.Append("Usex,");
				strSql2.Append(""+(model.Usex? 1 : 0) +",");
			}
			if (model.UClass != null)
			{
				strSql1.Append("UClass,");
				strSql2.Append(""+model.UClass+",");
			}
			if (model.UStatement != null)
			{
				strSql1.Append("UStatement,");
				strSql2.Append("'"+model.UStatement+"',");
			}
			if (model.URegDate != null)
			{
				strSql1.Append("URegDate,");
				strSql2.Append("'"+model.URegDate+"',");
			}
			if (model.UState != null)
			{
				strSql1.Append("UState,");
				strSql2.Append(""+model.UState+",");
			}
			if (model.UPoint != null)
			{
				strSql1.Append("UPoint,");
				strSql2.Append(""+model.UPoint+",");
			}
			strSql.Append("insert into BBSUsers(");
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
		public bool Update(BBS.Model.BBSUsers model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BBSUsers set ");
			if (model.Uname != null)
			{
				strSql.Append("Uname='"+model.Uname+"',");
			}
			if (model.UPassword != null)
			{
				strSql.Append("UPassword='"+model.UPassword+"',");
			}
			else
			{
				strSql.Append("UPassword= null ,");
			}
			if (model.UEmail != null)
			{
				strSql.Append("UEmail='"+model.UEmail+"',");
			}
			if (model.UBirthday != null)
			{
				strSql.Append("UBirthday='"+model.UBirthday+"',");
			}
			if (model.Usex != null)
			{
				strSql.Append("Usex="+ (model.Usex? 1 : 0) +",");
			}
			else
			{
				strSql.Append("Usex= null ,");
			}
			if (model.UClass != null)
			{
				strSql.Append("UClass="+model.UClass+",");
			}
			else
			{
				strSql.Append("UClass= null ,");
			}
			if (model.UStatement != null)
			{
				strSql.Append("UStatement='"+model.UStatement+"',");
			}
			if (model.URegDate != null)
			{
				strSql.Append("URegDate='"+model.URegDate+"',");
			}
			if (model.UState != null)
			{
				strSql.Append("UState="+model.UState+",");
			}
			else
			{
				strSql.Append("UState= null ,");
			}
			if (model.UPoint != null)
			{
				strSql.Append("UPoint="+model.UPoint+",");
			}
			else
			{
				strSql.Append("UPoint= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where Uid="+ model.Uid+"");
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
		public bool Delete(int Uid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BBSUsers ");
			strSql.Append(" where Uid="+Uid+"" );
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
		public bool DeleteList(string Uidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BBSUsers ");
			strSql.Append(" where Uid in ("+Uidlist + ")  ");
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
		public BBS.Model.BBSUsers GetModel(int Uid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ");
			strSql.Append(" Uid,Uname,UPassword,UEmail,UBirthday,Usex,UClass,UStatement,URegDate,UState,UPoint ");
			strSql.Append(" from BBSUsers ");
			strSql.Append(" where Uid="+Uid+"" );
			BBS.Model.BBSUsers model=new BBS.Model.BBSUsers();
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
		public BBS.Model.BBSUsers DataRowToModel(DataRow row)
		{
			BBS.Model.BBSUsers model=new BBS.Model.BBSUsers();
			if (row != null)
			{
				if(row["Uid"]!=null && row["Uid"].ToString()!="")
				{
					model.Uid=int.Parse(row["Uid"].ToString());
				}
				if(row["Uname"]!=null)
				{
					model.Uname=row["Uname"].ToString();
				}
				if(row["UPassword"]!=null)
				{
					model.UPassword=row["UPassword"].ToString();
				}
				if(row["UEmail"]!=null)
				{
					model.UEmail=row["UEmail"].ToString();
				}
				if(row["UBirthday"]!=null && row["UBirthday"].ToString()!="")
				{
					model.UBirthday=DateTime.Parse(row["UBirthday"].ToString());
				}
				if(row["Usex"]!=null && row["Usex"].ToString()!="")
				{
					if((row["Usex"].ToString()=="1")||(row["Usex"].ToString().ToLower()=="true"))
					{
						model.Usex=true;
					}
					else
					{
						model.Usex=false;
					}
				}
				if(row["UClass"]!=null && row["UClass"].ToString()!="")
				{
					model.UClass=int.Parse(row["UClass"].ToString());
				}
				if(row["UStatement"]!=null)
				{
					model.UStatement=row["UStatement"].ToString();
				}
				if(row["URegDate"]!=null && row["URegDate"].ToString()!="")
				{
					model.URegDate=DateTime.Parse(row["URegDate"].ToString());
				}
				if(row["UState"]!=null && row["UState"].ToString()!="")
				{
					model.UState=int.Parse(row["UState"].ToString());
				}
				if(row["UPoint"]!=null && row["UPoint"].ToString()!="")
				{
					model.UPoint=int.Parse(row["UPoint"].ToString());
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
			strSql.Append("select Uid,Uname,UPassword,UEmail,UBirthday,Usex,UClass,UStatement,URegDate,UState,UPoint ");
			strSql.Append(" FROM BBSUsers ");
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
			strSql.Append(" Uid,Uname,UPassword,UEmail,UBirthday,Usex,UClass,UStatement,URegDate,UState,UPoint ");
			strSql.Append(" FROM BBSUsers ");
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
			strSql.Append("select count(1) FROM BBSUsers ");
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
				strSql.Append("order by T.Uid desc");
			}
			strSql.Append(")AS Row, T.*  from BBSUsers T ");
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

