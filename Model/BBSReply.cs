using System;
namespace BBS.Model
{
	/// <summary>
	/// BBSReply:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BBSReply
	{
		public BBSReply()
		{}
		#region Model
		private int _rid;
		private int _rtid;
		private int _rsid;
		private int _ruid;
		private string _rtopic;
		private string _rcontents;
		private DateTime _rtime= DateTime.Now;
		private int? _rclickcount=0;
		/// <summary>
		/// 
		/// </summary>
		public int RID
		{
			set{ _rid=value;}
			get{return _rid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RTID
		{
			set{ _rtid=value;}
			get{return _rtid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RSID
		{
			set{ _rsid=value;}
			get{return _rsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RUID
		{
			set{ _ruid=value;}
			get{return _ruid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RTopic
		{
			set{ _rtopic=value;}
			get{return _rtopic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RContents
		{
			set{ _rcontents=value;}
			get{return _rcontents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RTime
		{
			set{ _rtime=value;}
			get{return _rtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RClickCount
		{
			set{ _rclickcount=value;}
			get{return _rclickcount;}
		}
		#endregion Model

	}
}

