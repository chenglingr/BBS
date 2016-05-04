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

INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 1,N'民生',1,N'现代意义上的民生概念有广义和狭义之分。广义上的民生概念是指，凡是同民生有关的，包括直接相关和间接相关的事情都属于民生范围内的事情。这个概念的优点是充分强调民生问题的高度重要性和高度综合性，但其明显的不足在于，概念范围太大。狭义上的民生概念主要是从社会层面上着眼的。',5,5)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 2,N'人文',1,N'人文就是人类文化中的先进部分和核心部分，即先进的价值观及其规范。其集中体现是：重视人，尊重人，关心人，爱护人。简而言之，人文，即重视人的文化。人文，是一个动态的概念。《辞海》中这样写道：“人文指人类社会的各种文化现象”。',4,5)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 4,N'财经',1,N'财经是指财政经济。财经类专业是指经济类和经济管理类专业，常见的专业包括市场营销、会计、人力资源管理、金融、国际贸易、企业管理、统计、财税等，是近几年来人才市场上的热门专业。',0,0)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 5,N'时尚',1,N'时尚“时尚”这个词现在已是很流行的了，英文为fashion，该词来源于拉丁文“facio or factio”，意思是“making or doing”（制造的或人为的），是对一种外表行为模式的崇尚方式。追求时尚似已蔚然成风，时尚就是在特定时段内率先由少数人实验、而后来为社会大众所崇尚和仿效的生活样式。',0,0)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 7,N'娱乐',1,N'观众参与的娱乐，可以是被动的如看歌剧，或者主动的如玩电脑游戏。而提供娱乐的行业称为娱乐行业。消闲、游戏、阅读还有视觉艺术欣赏普遍地不被认为是娱乐。因为娱乐的一般定义是需要有观看者可见的表演提供者。',0,0)
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 8,N'情感',1,N'情感是态度这一整体中的一部分，它与态度中的内向感受、意向具有协调一致性，是态度在生理上一种较复杂而又稳定的生理评价和体验。情感包括道德感和价值感两个方面，具体表现为爱情、幸福、仇恨、厌恶、美感等等。',0,0)

SET IDENTITY_INSERT [BBSSection] OFF
if exists (select * from sysobjects where id = OBJECT_ID('[BBSTopic]') and OBJECTPROPERTY(id, 'IsUserTable') = 1) 
DROP TABLE [BBSTopic]

CREATE TABLE [BBSTopic] (
[tid] [int]  IDENTITY (1, 1)  NOT NULL,
[tsid] [int]  NOT NULL,
[tuid] [int]  NOT NULL,
[treplycount] [int]  NULL DEFAULT (0),
[TTopic] [varchar]  (30) NOT NULL,
[TContents] [text]  NOT NULL,
[TTime] [datetime]  NULL DEFAULT (getdate()),
[TClickCount] [int]  NULL DEFAULT (0),
[TLastClickT] [datetime]  NULL DEFAULT (getdate()))

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

INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 1,N'张龙',N'123456',N'1990@yahoo.com.cn',N'1990/12/12 0:00:00',1,0,N'ANGEL',N'2010/5/7 0:00:00',2,0)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 2,N'妄想者',N'654321',N'1965@yahoo.com.cn',N'1980/7/1 0:00:00',1,0,N'ANGEL',N'2011/4/7 0:00:00',2,4)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 3,N'刺客',N'158664',N'conao@yahoo.com.cn',N'1997/1/3 0:00:00',1,0,N'ANGEL',N'2009/5/7 0:00:00',2,3)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 4,N'毁灭',N'175175',N'death@yahoo.com.cn',N'1992/1/4 0:00:00',1,0,N'ANGEL',N'2008/5/4 0:00:00',2,2)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 5,N'魔女',N'198755',N'sgg@yahoo.com.cn',N'1994/1/4 0:00:00',1,0,N'ANGEL',N'2000/12/12 0:00:00',1,100)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 6,N'魔王',N'192445',N'dsfg@yahoo.com.cn',N'1994/12/14 0:00:00',1,0,N'fdfs',N'2000/12/12 0:00:00',1,97)
INSERT [BBSUsers] ([Uid],[Uname],[UPassword],[UEmail],[UBirthday],[Usex],[UClass],[UStatement],[URegDate],[UState],[UPoint]) VALUES ( 10,N'admin',N'123456',N'11@q.com',N'2016/5/2 0:00:00',1,1,N'34',N'2016/5/2 0:00:12',1,20)

SET IDENTITY_INSERT [BBSUsers] OFF
