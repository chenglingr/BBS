if exists (select * from sysobjects where id = OBJECT_ID('[BBSReply]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [BBSReply]

CREATE TABLE [BBSReply] (
[RID] [int]  IDENTITY (1, 1)  NOT NULL,
[RTID] [int]  NOT NULL,
[RSID] [int]  NOT NULL,
[RUID] [int]  NOT NULL,
[RTopic] [varchar]  (230) NULL,
[RContents] [text]  NOT NULL,
[RTime] [datetime]  NULL DEFAULT (getdate()),
[RClickCount] [int]  NULL DEFAULT (0))

ALTER TABLE [BBSReply] WITH NOCHECK ADD  CONSTRAINT [PK_BBSReply] PRIMARY KEY  NONCLUSTERED ( [RID] )
SET IDENTITY_INSERT [BBSReply] ON

INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 2,1,1,1,N'test1',N'432432',N'2016/5/8 14:46:36',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 3,1,1,1,N'test2',N'���˹���',N'2016/5/8 14:47:20',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 4,1,1,1,N'test4',N'4����',N'2016/5/8 14:47:30',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 5,1,1,1,N'test5',N'54354',N'2016/5/8 15:25:09',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 6,1,1,1,N'test4',N'54354',N'2016/5/8 15:25:20',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 7,1,1,1,N'��ɫͨ��',N'54353334',N'2016/5/8 15:25:25',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 8,1,1,1,N'�ޱ���444',N'44444444444444444444444444444
0-0',N'2016/5/8 15:36:40',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 9,1,1,1,N'�ޱ���',N'����������',N'2016/5/8 15:40:37',0)

SET IDENTITY_INSERT [BBSReply] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[BBSSection]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [BBSSection]

CREATE TABLE [BBSSection] (
[SID] [int]  IDENTITY (1, 1)  NOT NULL,
[SName] [varchar]  (20) NOT NULL,
[SMasterID] [int]  NULL,
[SStatement] [varchar]  (300) NULL,
[SClickCount] [int]  NULL DEFAULT ('0'),
[STopicCount] [int]  NULL DEFAULT ('0'))

ALTER TABLE [BBSSection] WITH NOCHECK ADD  CONSTRAINT [PK_BBSSection] PRIMARY KEY  NONCLUSTERED ( [SID] )
SET IDENTITY_INSERT [BBSSection] ON

INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 1,N'����',1,N'�ִ������ϵ����������й��������֮�֡������ϵ�����������ָ������ͬ�����йصģ�����ֱ����غͼ����ص����鶼����������Χ�ڵ����顣���������ŵ��ǳ��ǿ����������ĸ߶���Ҫ�Ժ͸߶��ۺ��ԣ��������ԵĲ������ڣ����Χ̫�������ϵ�����������Ҫ�Ǵ������������۵ġ�',5,5)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 2,N'����',1,N'���ľ��������Ļ��е��Ƚ����ֺͺ��Ĳ��֣����Ƚ��ļ�ֵ�ۼ���淶���伯�������ǣ������ˣ������ˣ������ˣ������ˡ������֮�����ģ��������˵��Ļ������ģ���һ����̬�ĸ�����Ǻ���������д����������ָ�������ĸ����Ļ����󡱡�',4,5)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 4,N'�ƾ�',1,N'�ƾ���ָ�������á��ƾ���רҵ��ָ������;��ù�����רҵ��������רҵ�����г�Ӫ������ơ�������Դ�������ڡ�����ó�ס���ҵ����ͳ�ơ���˰�ȣ��ǽ��������˲��г��ϵ�����רҵ��',0,0)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 5,N'ʱ��',1,N'ʱ�С�ʱ�С�������������Ǻ����е��ˣ�Ӣ��Ϊfashion���ô���Դ�������ġ�facio or factio������˼�ǡ�making or doing��������Ļ���Ϊ�ģ����Ƕ�һ�������Ϊģʽ�ĳ��з�ʽ��׷��ʱ������εȻ�ɷ磬ʱ�о������ض�ʱ����������������ʵ�顢������Ϊ�����������кͷ�Ч��������ʽ��',0,0)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 7,N'����',1,N'���ڲ�������֣������Ǳ������翴��磬�������������������Ϸ�����ṩ���ֵ���ҵ��Ϊ������ҵ�����С���Ϸ���Ķ������Ӿ����������ձ�ز�����Ϊ�����֡���Ϊ���ֵ�һ�㶨������Ҫ�йۿ��߿ɼ��ı����ṩ�ߡ�',0,0)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 8,N'���',1,N'�����̬����һ�����е�һ���֣�����̬���е�������ܡ��������Э��һ���ԣ���̬����������һ�ֽϸ��Ӷ����ȶ����������ۺ����顣��а������¸кͼ�ֵ���������棬�������Ϊ���顢�Ҹ�����ޡ�������еȵȡ�',0,0)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 9,N'����',1,N'���˵��ô',0,0)

SET IDENTITY_INSERT [BBSSection] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[BBSTopic]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [BBSTopic]

CREATE TABLE [BBSTopic] (
[tid] [int]  IDENTITY (1, 1)  NOT NULL,
[tsid] [int]  NOT NULL,
[tuid] [int]  NOT NULL,
[treplycount] [int]  NULL DEFAULT (0),
[TTopic] [varchar]  (60) NOT NULL,
[TContents] [text]  NOT NULL,
[TTime] [datetime]  NULL DEFAULT (getdate()),
[TClickCount] [int]  NULL DEFAULT (0),
[TLastClickT] [datetime]  NULL DEFAULT (getdate()))

ALTER TABLE [BBSTopic] WITH NOCHECK ADD  CONSTRAINT [PK_BBSTopic] PRIMARY KEY  NONCLUSTERED ( [tid] )
SET IDENTITY_INSERT [BBSTopic] ON

INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 1,1,1,0,N'�Ϻ����������ᵺ���ܹ�ע ר�ң���ս�׵����',N'����������5��3�յ� ������ ���Ӿ꣩���գ��Ϻ�������֯�����������������ܹ�ע��һ����ĳ��½��֧�����Ϻ�������֯�Ķᵺ��������һ����ĳǱ֧ͧ����ĳ������ˮ�潢ͧ���ձ�չ��Эͬ����������ר����׿�ڽ������ӡ����չ�ע���ɷ�ʱ��ʾ������������ս�����Ϻ�����ÿ��ı�����Ŀ�����������ǳ�̬����������ϰ����ÿ�궼�Ჹ���µ����ݣ������µĿ�Ŀ�������ӱ������Ϻ�����ĳ��½��֧�����Ϻ���֯�Ķᵺ�����У��й�����������ǿ�����ܵ�½�������洬��װ��Ϥ�����࣬����ģ���ȡǧ��֮���ĳ��С������ϰ���ú����Կ���ģʽ���췽��½��ͧ��ӣ������ܴ����½��������ɽ��������ָ�ӽ��������������������κ�ǿ��������ƣ��Ժ췽��½����ʵʩ�����������ɽ�����ִ�ĳ�������Ժ������漴չ�������͵�½�����ӡ�����ɽ��������������������������麣����½��ս�����ڸ��ӻ����µĵ�½��ս���������������ܴ����½��������ͧ��½ս����֮���Эͬ�����������Ч��չ�������½ͧ����ս���÷�Χ��',N'2011/1/10 0:00:00',5,N'2011/6/24 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 2,1,2,0,N'�������ƶ�ͯ��Ϣй¶�� �ڿ��������߹滮ϵͳ',N'4��6�գ�����³Ҽ�㡱��վ����һƪ��Ϊ������20��ͯ��Ϣ��������ۣ�ÿ����Ϣ�۸�һ��ë�������£��������㷺��ע�������й�����Ѹ���ж�����֯���ƾ�������ר���飬�Ⱥ��Ĵ����㶫�������ȵأ�ȫ����չ������鹤����',N'2011/4/10 0:00:00',4,N'2011/6/28 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 3,2,1,0,N'����һ�����û�巿� ���ѵ�٩�����ª������',N'2016��5��2�գ���������С������������֡����ª������������ϵ�û�巿����ſ����ҡ������¡����ң����ѵ�٩������������ϡ����ª����������',N'2011/1/10 0:00:00',3,N'2011/6/27 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 4,2,5,0,N'��ˮ����2~~',N'DEVIL MAY CRY',N'2011/1/10 0:00:00',0,N'2011/6/26 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 5,2,4,0,N'��ˮ����3~~',N'DEVIL MAY CRY',N'2011/4/10 0:00:00',1,N'2011/6/24 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 7,1,1,0,N'test',N'<p>������</p><p>����<span style="color:#e36c09">дһЩ</span>��</p><p>��<span style="background-color: rgb(192, 0, 0);">��ʾ</span></p>',N'2016/5/8 13:34:40',0,N'2016/5/8 13:34:40')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 8,1,1,0,N'����',N'<p>�����ҿ���дһrey</p><p>Щ������ʾ</p><p><img src="http://localhost:61481/Web/User/upload/2016-05-08/0ea0233d-f596-41f7-9df4-859ba89a975b.jpg" _src="http://localhost:61481/Web/User/upload/2016-05-08/0ea0233d-f596-41f7-9df4-859ba89a975b.jpg" style="width: 91px; height: 119px;"/></p>',N'2016/5/8 15:51:41',0,N'2016/5/8 15:51:41')

SET IDENTITY_INSERT [BBSTopic] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[BBSUsers]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [BBSUsers]

CREATE TABLE [BBSUsers] (
[Uid] [int]  IDENTITY (1, 1)  NOT NULL,
[Uname] [varchar]  (15) NOT NULL,
[UPassword] [varchar]  (50) NOT NULL DEFAULT ('888888'),
[UEmail] [varchar]  (50) NOT NULL,
[UBirthday] [datetime]  NULL DEFAULT (getdate()),
[Usex] [bit]  NULL DEFAULT ('1'),
[UClass] [int]  NULL DEFAULT ('1'),
[UStatement] [varchar]  (150) NULL,
[URegDate] [datetime]  NULL DEFAULT (getdate()),
[UState] [tinyint]  NULL DEFAULT ('1'),
[UPoint] [int]  NULL DEFAULT ('20'))

ALTER TABLE [BBSUsers] WITH NOCHECK ADD  CONSTRAINT [PK_BBSUsers] PRIMARY KEY  NONCLUSTERED ( [Uid] )
SET IDENTITY_INSERT [BBSUsers] ON

INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 1,N'����',N'123456',N'1990@yahoo.com.cn',N'1990/12/12 0:00:00',1,0,N'ANGEL',N'2010/5/7 0:00:00',2,0)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 2,N'������',N'654321',N'1965@yahoo.com.cn',N'1980/7/1 0:00:00',1,0,N'ANGEL',N'2011/4/7 0:00:00',2,4)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 3,N'�̿�',N'158664',N'conao@yahoo.com.cn',N'1997/1/3 0:00:00',1,0,N'ANGEL',N'2009/5/7 0:00:00',2,3)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 4,N'����',N'175175',N'death@yahoo.com.cn',N'1992/1/4 0:00:00',1,0,N'ANGEL',N'2008/5/4 0:00:00',2,2)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 5,N'ħŮ',N'198755',N'sgg@yahoo.com.cn',N'1994/1/4 0:00:00',1,0,N'ANGEL',N'2000/12/12 0:00:00',1,100)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 6,N'ħ��',N'192445',N'dsfg@yahoo.com.cn',N'1994/12/14 0:00:00',1,0,N'fdfs',N'2000/12/12 0:00:00',1,97)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 10,N'admin',N'123456',N'11@q.com',N'2016/5/2 0:00:00',1,1,N'34',N'2016/5/2 0:00:12',1,20)

SET IDENTITY_INSERT [BBSUsers] OFF
