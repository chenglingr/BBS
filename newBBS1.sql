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
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 3,1,1,1,N'test2',N'人人公认',N'2016/5/8 14:47:20',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 4,1,1,1,N'test4',N'4让软',N'2016/5/8 14:47:30',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 5,1,1,1,N'test5',N'54354',N'2016/5/8 15:25:09',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 6,1,1,1,N'test4',N'54354',N'2016/5/8 15:25:20',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 7,1,1,1,N'特色通过',N'54353334',N'2016/5/8 15:25:25',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 8,1,1,1,N'无标题444',N'44444444444444444444444444444
0-0',N'2016/5/8 15:36:40',0)
INSERT [BBSReply] ([RID],[RTID],[RSID],[RUID],[RTopic],[RContents],[RTime],[RClickCount]) VALUES ( 9,1,1,1,N'无标题',N'炒作宣传下',N'2016/5/8 15:40:37',0)

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
INSERT [BBSSection] ([SID],[SName],[SMasterID],[SStatement],[SClickCount],[STopicCount]) VALUES ( 9,N'其他',1,N'随便说很么',0,0)

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

INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 1,1,1,0,N'南海舰队演练夺岛备受关注 专家：开战首当其冲',N'人民网北京5月3日电 （记者 黄子娟）近日，南海舰队组织了两场联合演练备受关注。一场是某登陆舰支队在南海海域组织的夺岛演练，另一场是某潜艇支队在某海域与水面舰艇航空兵展开协同演练。军事专家尹卓在接受央视《今日关注》采访时表示，岛礁争夺作战，是南海舰队每年的必练科目。这种演练是常态化的例行演习，但每年都会补充新的内容，增加新的科目。据央视报道，南海舰队某登陆舰支队在南海组织的夺岛演练中，中国海军现役最强的两栖登陆舰和气垫船等装备悉数亮相，演练模拟夺取千里之外的某座小岛，演习采用红蓝对抗的模式。红方登陆舰艇编队，由两栖船坞登陆舰“长白山”舰担任指挥舰，蓝军则依托有利地形和强大火力优势，对红方登陆兵力实施阻击。“长白山”舰抵达某任务海域以后演练随即展开，各型登陆力量从“长白山”舰的坞舱中鱼贯而出。演练检验海军登陆作战部队在复杂环境下的登陆作战能力，提升了两栖船坞登陆舰、气垫艇和陆战部队之间的协同配合能力，有效拓展了气垫登陆艇的作战利用范围。',N'2011/1/10 0:00:00',5,N'2011/6/24 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 2,1,2,0,N'济南侦破儿童信息泄露案 黑客入侵免疫规划系统',N'4月6日，“齐鲁壹点”网站发布一篇题为《济南20万孩童信息被打包出售！每条信息价格一两毛》的文章，引起社会广泛关注。济南市公安局迅速行动，组织优势警力成立专案组，先后赴四川、广东、福建等地，全力开展案件侦查工作。',N'2011/4/10 0:00:00',4,N'2011/6/28 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 3,2,1,0,N'昆明一寺庙用活动板房搭建 网友调侃“最简陋”庙宇',N'2016年5月2日，云南昆明小康大道附近惊现“最简陋”寺庙，该寺庙系用活动板房搭建，门口悬挂“西京寺”牌匾，网友调侃，这可能是世上“最简陋”的寺庙了',N'2011/1/10 0:00:00',3,N'2011/6/27 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 4,2,5,0,N'灌水来着2~~',N'DEVIL MAY CRY',N'2011/1/10 0:00:00',0,N'2011/6/26 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 5,2,4,0,N'灌水来着3~~',N'DEVIL MAY CRY',N'2011/4/10 0:00:00',1,N'2011/6/24 0:00:00')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 7,1,1,0,N'test',N'<p>这里我</p><p>可以<span style="color:#e36c09">写一些</span>输</p><p>入<span style="background-color: rgb(192, 0, 0);">提示</span></p>',N'2016/5/8 13:34:40',0,N'2016/5/8 13:34:40')
INSERT [BBSTopic] ([tid],[tsid],[tuid],[treplycount],[TTopic],[TContents],[TTime],[TClickCount],[TLastClickT]) VALUES ( 8,1,1,0,N'哈哈',N'<p>这里我可以写一rey</p><p>些输入提示</p><p><img src="http://localhost:61481/Web/User/upload/2016-05-08/0ea0233d-f596-41f7-9df4-859ba89a975b.jpg" _src="http://localhost:61481/Web/User/upload/2016-05-08/0ea0233d-f596-41f7-9df4-859ba89a975b.jpg" style="width: 91px; height: 119px;"/></p>',N'2016/5/8 15:51:41',0,N'2016/5/8 15:51:41')

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
