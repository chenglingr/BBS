using System;
using System.Reflection;
using System.Configuration;
namespace BBS.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="Maticsoft.SQLServerDAL" />。
	/// </summary>
	public sealed class DataAccess 
	{
        private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];        
		public DataAccess()
		{ }

        #region CreateObject 

		//不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// 记录错误日志
				return null;
			}			
			
        }
		//使用缓存
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.GetCache(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.SetCache(classNamespace, objType);// 写入缓存
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// 记录错误日志
				}
			}
			return objType;
		}
        #endregion

        #region 泛型生成
        ///// <summary>
        ///// 创建数据层接口。
        ///// </summary>
        //public static t Create(string ClassName)
        //{

        //    string ClassNamespace = AssemblyPath +"."+ ClassName;
        //    object objType = CreateObject(AssemblyPath, ClassNamespace);
        //    return (t)objType;
        //}
        #endregion


             
        
   
		/// <summary>
		/// 创建BBSReply数据层接口。
		/// </summary>
		public static BBS.IDAL.IBBSReply CreateBBSReply()
		{

			string ClassNamespace = AssemblyPath +".BBSReply";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (BBS.IDAL.IBBSReply)objType;
		}


		/// <summary>
		/// 创建BBSSection数据层接口。
		/// </summary>
		public static BBS.IDAL.IBBSSection CreateBBSSection()
		{

			string ClassNamespace = AssemblyPath +".BBSSection";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (BBS.IDAL.IBBSSection)objType;
		}


		/// <summary>
		/// 创建BBSTopic数据层接口。
		/// </summary>
		public static BBS.IDAL.IBBSTopic CreateBBSTopic()
		{

			string ClassNamespace = AssemblyPath +".BBSTopic";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (BBS.IDAL.IBBSTopic)objType;
		}


		/// <summary>
		/// 创建BBSUsers数据层接口。
		/// </summary>
		public static BBS.IDAL.IBBSUsers CreateBBSUsers()
		{

			string ClassNamespace = AssemblyPath +".BBSUsers";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (BBS.IDAL.IBBSUsers)objType;
		}
        /*
        public static BBS.IDAL.IBBSUsers CreateBBSUsers()
        {

            string ClassNamespace = AssemblyPath + ".BBSUsers";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (BBS.IDAL.IBBSUsers)objType;
        }
        */
    }
}