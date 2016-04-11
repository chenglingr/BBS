if exists (select * from sysobjects where id = OBJECT_ID('[BBSReply]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [BBSReply]

CREATE TABLE [BBSReply] (
[RID] [int]  IDENTITY (1, 1)  NOT NULL,
[RTID] [int]  NULL,
[RSID] [int]  NULL,
[RUID] [int]  NULL,
[RTopic] [varchar]  (230) NULL,
[RContents] [text]  NULL,
[RTime] [datetime]  NULL DEFAULT (getdate()),
[RClickCount] [int]  NULL DEFAULT (0))

ALTER TABLE [BBSReply] WITH NOCHECK ADD  CONSTRAINT [PK_BBSReply] PRIMARY KEY  NONCLUSTERED ( [RID] )
SET IDENTITY_INSERT [BBSReply] ON


SET IDENTITY_INSERT [BBSReply] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[BBSSection]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [BBSSection]

CREATE TABLE [BBSSection] (
[SID] [int]  IDENTITY (1, 1)  NOT NULL,
[SName] [varchar]  (20) NULL,
[SMasterID] [int]  NOT NULL,
[SStatement] [varchar]  (200) NULL,
[SClickCount] [int]  NULL DEFAULT ('0'),
[STopicCount] [int]  NULL DEFAULT ('0'))

ALTER TABLE [BBSSection] WITH NOCHECK ADD  CONSTRAINT [PK_BBSSection] PRIMARY KEY  NONCLUSTERED ( [SID] )
SET IDENTITY_INSERT [BBSSection] ON

INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 1,N'灌水堂',1,N'说废话的地方',5,5)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 2,N'游戏厅',1,N'说游戏的地方',4,5)

SET IDENTITY_INSERT [BBSSection] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[BBSTopic]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [BBSTopic]

CREATE TABLE [BBSTopic] (
[tid] [int]  IDENTITY (1, 1)  NOT NULL,
[tsid] [int]  NOT NULL,
[tuid] [int]  NOT NULL,
[treplycount] [int]  NOT NULL,
[TTopic] [varchar]  (30) NOT NULL,
[TContents] [text]  NOT NULL,
[TTime] [datetime]  NOT NULL DEFAULT (getdate()),
[TClickCount] [int]  NOT NULL,
[TLastClickT] [datetime]  NOT NULL)

ALTER TABLE [BBSTopic] WITH NOCHECK ADD  CONSTRAINT [PK_BBSTopic] PRIMARY KEY  NONCLUSTERED ( [tid] )
SET IDENTITY_INSERT [BBSTopic] ON

INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 1,1,1,0,N'我是魔王',N'DEVIL MAY CRY',N'2011/1/10 0:00:00',5,N'2011/6/24 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 2,1,2,0,N'灌水来着~~',N'DEVIL MAY CRY',N'2011/4/10 0:00:00',4,N'2011/6/28 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 3,2,1,0,N'灌水来着1~~',N'DEVIL MAY CRY',N'2011/1/10 0:00:00',3,N'2011/6/27 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 4,2,5,0,N'灌水来着2~~',N'DEVIL MAY CRY',N'2011/1/10 0:00:00',0,N'2011/6/26 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 5,2,4,0,N'灌水来着3~~',N'DEVIL MAY CRY',N'2011/4/10 0:00:00',1,N'2011/6/24 0:00:00')

SET IDENTITY_INSERT [BBSTopic] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[BBSUsers]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [BBSUsers]

CREATE TABLE [BBSUsers] (
[Uid] [int]  IDENTITY (1, 1)  NOT NULL,
[Uname] [varchar]  (15) NOT NULL,
[UPassword] [varchar]  (50) NULL DEFAULT ('888888'),
[UEmail] [varchar]  (50) NOT NULL,
[UBirthday] [datetime]  NOT NULL,
[Usex] [bit]  NULL DEFAULT ('1'),
[UClass] [int]  NULL DEFAULT ('1'),
[UStatement] [varchar]  (150) NOT NULL,
[URegDate] [datetime]  NOT NULL DEFAULT (getdate()),
[UState] [tinyint]  NULL DEFAULT ('1'),
[UPoint] [int]  NULL DEFAULT ('20'))

ALTER TABLE [BBSUsers] WITH NOCHECK ADD  CONSTRAINT [PK_BBSUsers] PRIMARY KEY  NONCLUSTERED ( [Uid] )
SET IDENTITY_INSERT [BBSUsers] ON

INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 1,N'张龙',N'123456',N'1990@yahoo.com.cn',N'1990/12/12 0:00:00',1,0,N'ANGEL',N'2010/5/7 0:00:00',2,0)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 2,N'妄想者',N'654321',N'1965@yahoo.com.cn',N'1980/7/1 0:00:00',1,0,N'ANGEL',N'2011/4/7 0:00:00',2,4)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 3,N'刺客',N'158664',N'conao@yahoo.com.cn',N'1997/1/3 0:00:00',1,0,N'ANGEL',N'2009/5/7 0:00:00',2,3)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 4,N'毁灭',N'175175',N'death@yahoo.com.cn',N'1992/1/4 0:00:00',1,0,N'ANGEL',N'2008/5/4 0:00:00',2,2)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 5,N'魔女',N'198755',N'sgg@yahoo.com.cn',N'1994/1/4 0:00:00',1,0,N'ANGEL',N'2000/12/12 0:00:00',1,100)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 6,N'魔王',N'192445',N'dsfg@yahoo.com.cn',N'1994/12/14 0:00:00',1,0,N'fdfs',N'2000/12/12 0:00:00',1,97)

SET IDENTITY_INSERT [BBSUsers] OFF
