CREATE TABLE Users (
  id int not null PRIMARY KEY IDENTITY(1,1),
  UserName NVARCHAR(100),
  CatName NVARCHAR(100),
  CatAge tinyint,
  CatGender BIT,
  CatBreed NVARCHAR(100),
  Account VARCHAR(100),
  Password VARCHAR(100),
  Phone VARCHAR(100)
);

CREATE TABLE Rooms (
  id int not null PRIMARY KEY IDENTITY(1,1),
  Price int not null,
  Description NVARCHAR(100),
  RoomsImages NVARCHAR(100) not null
);

CREATE TABLE Orders (
  id int not null PRIMARY KEY IDENTITY(1,1),
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
select*from Rooms;