using System;
namespace BBS.Model
{
	/// <summary>
	/// BBSTopic:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BBSTopic
	{
		public BBSTopic()
		{}
		#region Model
		private int _tid;
		private int _tsid;
		private int _tuid;
		private int _treplycount;
		private string _ttopic;
		private string _tcontents;
		private DateTime _ttime= DateTime.Now;
		private int _tclickcount;
		private DateTime _tlastclickt;
		/// <summary>
		/// 
		/// </summary>
		public int tid
		{
			set{ _tid=value;}
			get{return _tid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tsid
		{
			set{ _tsid=value;}
			get{return _tsid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int tuid
		{
			set{ _tuid=value;}
			get{return _tuid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int treplycount
		{
			set{ _treplycount=value;}
			get{return _treplycount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTopic
		{
			set{ _ttopic=value;}
			get{return _ttopic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TContents
		{
			set{ _tcontents=value;}
			get{return _tcontents;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TTime
		{
			set{ _ttime=value;}
			get{return _ttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int TClickCount
		{
			set{ _tclickcount=value;}
			get{return _tclickcount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TLastClickT
		{
			set{ _tlastclickt=value;}
			get{return _tlastclickt;}
		}
		#endregion Model

	}
}

