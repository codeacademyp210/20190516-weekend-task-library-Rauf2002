--CREATE TABLE Categories (
--	Id int IDENTITY(1,1) PRIMARY KEY,
--	Name nvarchar(100) NOT NULL
--);
--INSERT INTO Categories (Name)
--VALUES ('Fantasy'),
--('Sci-Fi'),
--('Romance')

--CREATE TABLE Clients (
--	Id int IDENTITY(1,1) PRIMARY KEY,
--	Name nvarchar(100) NOT NULL,
--	Surname nvarchar(50) NOT NULL,
--	Phone nvarchar(50) NOT NULL, 
--	Email nvarchar(50) NOT NULL,
--	Status bit
--);
--INSERT INTO Clients (Name,Surname,Phone,Email)
--VALUES ('Rauf','Allahverdiyev','+994508507575','raufsa@code.edu.az')

--CREATE TABLE Authors (
--	Id int IDENTITY(1,1) PRIMARY KEY,
--	Name nvarchar(50) NOT NULL,
--	Surname nvarchar(50) NOT NULL
--);
--INSERT INTO Authors (Name,Surname)
--VALUES ('Fyodr','Dostoyevski'),
--('Mark','Twain'),
--('Agatha','Christie')

--CREATE TABLE Books (
--	Id int IDENTITY(1,1) PRIMARY KEY,
--	Name nvarchar(50) NOT NULL,
--	Price decimal NOT NULL,
--	CategoryId int FOREIGN KEY REFERENCES Categories(Id) NOT NULL,
--	Quantity int NOT NULL
--);

--INSERT INTO Books (Name,Price,CategoryId,Quantity)
--VALUES ('Romeo and Juliet',15.99,3,30),
--('1984',17.99,2,45)


--CREATE TABLE Orders(
--	Id int IDENTITY(1,1) PRIMARY KEY,
--	ClientId int FOREIGN KEY REFERENCES Clients(Id)	NOT NULL,
--	BookId int FOREIGN KEY REFERENCES Books(Id)	NOT NULL,
--	OrderDate Datetime NOT NULL,
--	ReturnDate Datetime NOT NULL
--);

--CREATE TABLE AuthorsBooks (
--	Id int IDENTITY(1,1) PRIMARY KEY,
--	AuthorId int FOREIGN KEY REFERENCES Authors(Id)	NOT NULL,
--	BookId int FOREIGN KEY REFERENCES Books(Id)	NOT NULL,
--);


