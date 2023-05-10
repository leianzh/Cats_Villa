USE [Cats_Villa]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2023/5/10 下午 09:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
	[RoomType] [nvarchar](100) NOT NULL,
	[CheckInDate] [datetime] NOT NULL,
	[CheckOutDate] [datetime] NOT NULL,
	[OrderCreat_at] [datetime] NOT NULL,
	[OrderPrice] [int] NOT NULL,
 CONSTRAINT [PK__Orders__3214EC0713DBB1DC] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 2023/5/10 下午 09:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoomType] [nvarchar](100) NULL,
	[RoomPrice] [int] NOT NULL,
	[Title] [nvarchar](50) NULL,
	[Description] [nvarchar](3000) NULL,
	[RoomsImage] [nvarchar](100) NULL,
 CONSTRAINT [PK__Rooms__3214EC0725D43FC6] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2023/5/10 下午 09:10:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[CatName] [nvarchar](100) NOT NULL,
	[CatBirth] [datetime] NOT NULL,
	[CatGender] [nvarchar](100) NOT NULL,
	[CatBreed] [nvarchar](100) NOT NULL,
	[Account] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Phone] [varchar](100) NOT NULL,
 CONSTRAINT [PK__Users__3213E83F5F834528] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Id], [UserId], [RoomId], [RoomType], [CheckInDate], [CheckOutDate], [OrderCreat_at], [OrderPrice]) VALUES (1, 1, 1, N'經典房', CAST(N'2023-05-07T00:00:00.000' AS DateTime), CAST(N'2023-05-09T00:00:00.000' AS DateTime), CAST(N'2023-05-07T00:00:00.000' AS DateTime), 770)
INSERT [dbo].[Order] ([Id], [UserId], [RoomId], [RoomType], [CheckInDate], [CheckOutDate], [OrderCreat_at], [OrderPrice]) VALUES (2, 2, 2, N'尊爵房', CAST(N'2023-04-28T00:00:00.000' AS DateTime), CAST(N'2023-05-01T00:00:00.000' AS DateTime), CAST(N'2023-04-28T00:00:00.000' AS DateTime), 1000)
INSERT [dbo].[Order] ([Id], [UserId], [RoomId], [RoomType], [CheckInDate], [CheckOutDate], [OrderCreat_at], [OrderPrice]) VALUES (3, 3, 3, N'森林房', CAST(N'2023-03-29T00:00:00.000' AS DateTime), CAST(N'2023-04-01T00:00:00.000' AS DateTime), CAST(N'2023-03-29T00:00:00.000' AS DateTime), 2300)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([Id], [RoomType], [RoomPrice], [Title], [Description], [RoomsImage]) VALUES (1, N'經典房', 770, N' ', N' ', N' ')
INSERT [dbo].[Room] ([Id], [RoomType], [RoomPrice], [Title], [Description], [RoomsImage]) VALUES (2, N'尊爵房', 1000, N' ', N' ', N' ')
INSERT [dbo].[Room] ([Id], [RoomType], [RoomPrice], [Title], [Description], [RoomsImage]) VALUES (3, N'森林房', 2300, N' ', N' ', N' ')
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatBirth], [CatGender], [CatBreed], [Account], [Password], [Phone]) VALUES (1, N'Leian', N'蚵仔', CAST(N'2021-03-29T00:00:00.000' AS DateTime), N'female', N'mix', N'Leian666', N'LNN12345', N'0988699060')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatBirth], [CatGender], [CatBreed], [Account], [Password], [Phone]) VALUES (2, N'璇璇', N'喵喵', CAST(N'2019-05-08T00:00:00.000' AS DateTime), N'female', N'mix', N'yang888', N'mamamoo123', N'0912345678')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatBirth], [CatGender], [CatBreed], [Account], [Password], [Phone]) VALUES (3, N'蓁蓁123', N'1', CAST(N'2010-07-07T00:00:00.000' AS DateTime), N'male', N'persian', N'joy777', N'zzz123456', N'0955443226')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatBirth], [CatGender], [CatBreed], [Account], [Password], [Phone]) VALUES (4, N'平平', N'安安', CAST(N'2022-11-22T00:00:00.000' AS DateTime), N'female', N'russian blue', N'happy99', N'abcd1234', N'0934637802')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatBirth], [CatGender], [CatBreed], [Account], [Password], [Phone]) VALUES (5, N'Hank', N'12', CAST(N'2017-12-12T00:00:00.000' AS DateTime), N'male', N'mix', N'HHANK12', N'xnr23456', N'0933675803')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatBirth], [CatGender], [CatBreed], [Account], [Password], [Phone]) VALUES (6, N'理恩', N'uhah', CAST(N'2023-03-29T00:00:00.000' AS DateTime), N'female', N'mix', N'Leian0', N'uxnny500', N'0956321890')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatBirth], [CatGender], [CatBreed], [Account], [Password], [Phone]) VALUES (21, N'test', N'cat', CAST(N'1997-08-26T00:00:00.000' AS DateTime), N'male', N'mix', N'test123', N'test12345', N'0988699543')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK__Orders__RoomId__286302EC] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK__Orders__RoomId__286302EC]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK__Orders__UserId__3B75D760] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK__Orders__UserId__3B75D760]
GO
