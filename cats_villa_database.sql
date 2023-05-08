USE [Cats_Villa]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2023/5/8 下午 09:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
	[CheckInDate] [datetime] NOT NULL,
	[CheckOutDate] [datetime] NOT NULL,
	[StayDuration] [int] NOT NULL,
	[OrderCreat_at] [datetime] NOT NULL,
	[OrderStatus] [nvarchar](100) NOT NULL,
	[PayerName] [nvarchar](100) NOT NULL,
	[Price] [int] NOT NULL,
	[PayerAccount] [varchar](100) NOT NULL,
	[PaymentTime] [datetime] NOT NULL,
 CONSTRAINT [PK__Orders__3214EC0713DBB1DC] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 2023/5/8 下午 09:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Price] [int] NOT NULL,
	[Description] [nvarchar](100) NULL,
	[RoomsImages] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2023/5/8 下午 09:11:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[CatName] [nvarchar](100) NOT NULL,
	[CatAge] [int] NOT NULL,
	[CatGender] [nvarchar](100) NOT NULL,
	[CatBreed] [nvarchar](100) NOT NULL,
	[Account] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[ConfirmPassword] [varchar](100) NOT NULL,
	[Phone] [varchar](100) NOT NULL,
 CONSTRAINT [PK__Users__3213E83F5F834528] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatAge], [CatGender], [CatBreed], [Account], [Password], [ConfirmPassword], [Phone]) VALUES (1, N'Leian', N'蚵仔', 3, N'female', N'mix', N'Leian666', N'LNN12345', N'LNN12345', N'0988699060')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatAge], [CatGender], [CatBreed], [Account], [Password], [ConfirmPassword], [Phone]) VALUES (2, N'璇璇', N'喵喵', 2, N'female', N'mix', N'yang888', N'mamamoo123', N'mamamoo123', N'0912345678')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatAge], [CatGender], [CatBreed], [Account], [Password], [ConfirmPassword], [Phone]) VALUES (3, N'蓁蓁', N'Sun', 5, N'male', N'persian', N'joy777', N'jjo67890', N'jjo67890', N'0955443226')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatAge], [CatGender], [CatBreed], [Account], [Password], [ConfirmPassword], [Phone]) VALUES (4, N'平平', N'安安', 7, N'female', N'russian blue', N'happy99', N'abcd1234', N'abcd1234', N'0934637802')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatAge], [CatGender], [CatBreed], [Account], [Password], [ConfirmPassword], [Phone]) VALUES (5, N'Hank', N'12', 7, N'male', N'mix', N'HHANK12', N'xnr23456', N'xnr23456', N'0933675803')
INSERT [dbo].[Users] ([Id], [UserName], [CatName], [CatAge], [CatGender], [CatBreed], [Account], [Password], [ConfirmPassword], [Phone]) VALUES (6, N'理恩', N'uhah', 3, N'female', N'mix', N'Leian0', N'uxnny500', N'uxnny500', N'0956321890')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__RoomId__286302EC] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__RoomId__286302EC]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK__Orders__UserId__3B75D760] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK__Orders__UserId__3B75D760]
GO
