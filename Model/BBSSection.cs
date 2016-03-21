using System;
namespace BBS.Model
{
	/// <summary>
	/// BBSSection:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BBSSection
	{
		public BBSSection()
		{}
		#region Model
		private int _sid;
		private string _sname;
		private int _smasterid;
		private string _sstatement;
		private int _sclickcount=0;
		private int _stopiccount=0;
		/// <summary>
		/// 
		/// </summary>
		public int SID
		{
			set{ _sid=value;}
			get{return _sid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SName
		{
			set{ _sname=value;}
			get{return _sname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SMasterID
		{
			set{ _smasterid=value;}
			get{return _smasterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SStatement
		{
			set{ _sstatement=value;}
			get{return _sstatement;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SClickCount
		{
			set{ _sclickcount=value;}
			get{return _sclickcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int STopicCount
		{
			set{ _stopiccount=value;}
			get{return _stopiccount;}
		}
		#endregion Model

	}
}

