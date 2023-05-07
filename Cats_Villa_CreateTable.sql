CREATE TABLE Users (
  Id int not null PRIMARY KEY IDENTITY(1,1),
  UserName NVARCHAR(100) not null,
  CatName NVARCHAR(100) not null,
  CatAge tinyint not null,
  CatGender NVARCHAR(100) not null,
  CatBreed NVARCHAR(100) not null,
  Account VARCHAR(100) not null,
  Password VARCHAR(100) not null,
  Phone VARCHAR(100) not null
);

CREATE TABLE Rooms (
  Id int not null PRIMARY KEY IDENTITY(1,1),
  Price int not null,
  Description NVARCHAR(100),
  RoomsImages NVARCHAR(100) not null
);

CREATE TABLE Orders (
  Id int not null PRIMARY KEY IDENTITY(1,1),
  UserId int not null,
  RoomId int not null,
  CheckInDate DATETIME not null,
  CheckOutDate DATETIME not null,
  StayDuration DATETIME not null,
  OrderCreatDate DATETIME not null,
  OrderStatus NVARCHAR(100),
  PayerName NVARCHAR(100) not null,
  PayerPrice int not null,
  PayerAccount VARCHAR(100) not null,
  PaymentTime DATETIME not null,
  foreign key (UserId) REFERENCES Users(id),
  foreign key (RoomId) REFERENCES Rooms(id)
);
SET IDENTITY_INSERT [dbo]. Users on
INSERT INTO Users (id,UserName, CatName,CatAge,CatGender,CatBreed,Account,Password,Phone) 
VALUES 
  (1,'Leian', '蚵仔',3,'female','mix','Leian666','LL123','0988699060'),
  (2,'璇璇', '喵喵',2,'female','mix','yang888','mamamoo','0912345678'),
  (3,'蓁蓁', 'Sun',5,'male','persian','joy777','jj67890','0955443226'),
  (4,'平平', '安安',7,'female','russian blue','happy99','abc123','0934637802'),
  (5,'Hank', '12',7,'male','mix','HHANK12','xnr234','0933675803');
  SELECT * FROM Users
  INSERT INTO Users (id,UserName, CatName,CatAge,CatGender,CatBreed,Account,Password,Phone) 
VALUES 
 (6,'理恩', 'uhah',3,'female','mix','Leian0','ux500','0956321890');








