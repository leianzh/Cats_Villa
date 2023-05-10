CREATE TABLE Users (
  Id int not null PRIMARY KEY IDENTITY(1,1),
  UserName NVARCHAR(100) not null,
  CatName NVARCHAR(100) not null,
  CatBirth DATETIME not null,
  CatGender NVARCHAR(100) not null,
  CatBreed NVARCHAR(100) not null,
  Account VARCHAR(100) not null,
  Password VARCHAR(100) not null,
  Phone VARCHAR(100) not null
);

CREATE TABLE Rooms (
  Id int not null PRIMARY KEY IDENTITY(1,1),
  Price int not null,
  Title NVARCHAR(50),
  Description NVARCHAR(3000),
  RoomsImage NVARCHAR(100) not null
);

CREATE TABLE Orders (
  Id int not null PRIMARY KEY IDENTITY(1,1),
  UserId int not null,
  RoomId int not null,
  CheckInDate DATETIME not null,
  CheckOutDate DATETIME not null,
  StayDuration INT not null,
  OrderCreat_at DATETIME not null,
  Price int not null,
  foreign key (UserId) REFERENCES Users(id),
  foreign key (RoomId) REFERENCES Rooms(id)
);


UPDATE users
SET CatBirth = '2023-03-29'
WHERE username = '理恩';

delete from users where id=21;

SELECT * FROM Users



SELECT * FROM Users

UPDATE Users SET Account = 'ACC123',Password = 'ZZZ12345' WHERE Id = 3;

select Title,Description,RoomPrice,CheckInDate,CheckOutDate
from Room
join [Order]
ON [Order].ROOMId = Room.Id

SET IDENTITY_INSERT [dbo].[Order] ON 
insert into [Order] (Id,UserId,RoomId,RoomType,CheckInDate,CheckOutDate,OrderCreat_at,OrderPrice)
values
(1,1,1,'經典房', '2023-05-07','2023-05-09','2023-05-07',770),

(2,2,2,'尊爵房', '2023-04-28','2023-05-01','2023-04-028',1000),
(3,3,3,'森林房', '2023-03-29','2023-04-01','2023-03-29',2300);

select * from [Order];




insert into [Room] (RoomPrice,Title,Description,RoomsImage)
values
(770,'經典房', ' ',' '),

(1000,'尊爵房', ' ',' '),
(2300,'森林房', ' ',' ');

select * from Room;

select * from [Order];

SELECT * FROM [Order]

UPDATE Room SET RoomType = '森林房',Title = ' ' WHERE Id = 3;















