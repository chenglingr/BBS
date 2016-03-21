using System;
using System.Data;
using System.Collections.Generic;
using Common;
using BBS.Model;
using BBS.DALFactory;
using BBS.IDAL;
namespace BBS.BLL
{
	/// <summary>
	/// BBSTopic
	/// </summary>
	public partial class BBSTopic
	{
		private readonly IBBSTopic dal=DataAccess.CreateBBSTopic();
		public BBSTopic()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int tid)
		{
			return dal.Exists(tid);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(BBS.Model.BBSTopic model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(BBS.Model.BBSTopic model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int tid)
		{
			
			return dal.Delete(tid);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string tidlist )
		{
			return dal.DeleteList(tidlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public BBS.Model.BBSTopic GetModel(int tid)
		{
			
			return dal.GetModel(tid);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public BBS.Model.BBSTopic GetModelByCache(int tid)
		{
			
			string CacheKey = "BBSTopicModel-" + tid;
			object objModel = Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(tid);
					if (objModel != null)
					{
						int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (BBS.Model.BBSTopic)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BBS.Model.BBSTopic> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<BBS.Model.BBSTopic> DataTableToList(DataTable dt)
		{
			List<BBS.Model.BBSTopic> modelList = new List<BBS.Model.BBSTopic>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				BBS.Model.BBSTopic model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

