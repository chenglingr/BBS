using System;
using System.Data;
namespace BBS.IDAL
{
	/// <summary>
	/// 接口层BBSSection
	/// </summary>
	public interface IBBSSection
	{
		#region  成员方法
		/// <summary>
		/// 得到最大ID
		/// </summary>
		int GetMaxId();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(int SID);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		int Add(BBS.Model.BBSSection model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(BBS.Model.BBSSection model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(int SID);
		bool DeleteList(string SIDlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		BBS.Model.BBSSection GetModel(int SID);
		BBS.Model.BBSSection DataRowToModel(DataRow row);
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
