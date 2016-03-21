using System;
using System.Data;
namespace BBS.IDAL
{
	/// <summary>
	/// 接口层BBSTopic
	/// </summary>
	public interface IBBSTopic
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int tid);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(BBS.Model.BBSTopic model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(BBS.Model.BBSTopic model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int tid);
		bool DeleteList(string tidlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		BBS.Model.BBSTopic GetModel(int tid);
		BBS.Model.BBSTopic DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
