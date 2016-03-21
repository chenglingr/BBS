using System;
namespace BBS.Model
{
	/// <summary>
	/// BBSUsers:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BBSUsers
	{
		public BBSUsers()
		{}
		#region Model
		private int _uid;
		private string _uname;
		private string _upassword="888888";
		private string _uemail;
		private DateTime _ubirthday;
		private bool _usex= true;
		private int _uclass=1;
		private string _ustatement;
		private DateTime _uregdate= DateTime.Now;
		private int _ustate=1;
		private int _upoint=20;
		/// <summary>
		/// 
		/// </summary>
		public int Uid
		{
			set{ _uid=value;}
			get{return _uid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Uname
		{
			set{ _uname=value;}
			get{return _uname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UPassword
		{
			set{ _upassword=value;}
			get{return _upassword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UEmail
		{
			set{ _uemail=value;}
			get{return _uemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime UBirthday
		{
			set{ _ubirthday=value;}
			get{return _ubirthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Usex
		{
			set{ _usex=value;}
			get{return _usex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UClass
		{
			set{ _uclass=value;}
			get{return _uclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UStatement
		{
			set{ _ustatement=value;}
			get{return _ustatement;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime URegDate
		{
			set{ _uregdate=value;}
			get{return _uregdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UState
		{
			set{ _ustate=value;}
			get{return _ustate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UPoint
		{
			set{ _upoint=value;}
			get{return _upoint;}
		}
		#endregion Model

	}
}

