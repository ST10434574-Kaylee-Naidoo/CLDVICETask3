--DATABSE CREATION SECTION
USE master 
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'IceTask3')
DROP DATABASE IceTask3
CREATE DATABASE IceTask3
USE IceTask3

--TABLE CREATION SECTION
CREATE TABLE [User] (
UserID INT IDENTITY (1,1)PRIMARY KEY NOT NULL,
Username VARCHAR(20) NOT NULL,
ProfilePicture VARCHAR(250) ,
Email VARCHAR(150) NOT NULL
);


--/--TABLE ALTERATION SECTION 

--TABLE INSERTION SECTION 
INSERT INTO [User] (Username,ProfilePicture,Email)
VALUES('KayleeNaidoo','https://tse2.mm.bing.net/th?id=OIP.eMLmzmhAqRMxUZad3zXE5QHaHa&pid=Api&P=0&h=220','naidoo.kaylee27gmail.com'),
('Neha','https://tse2.mm.bing.net/th?id=OIP.eMLmzmhAqRMxUZad3zXE5QHaHa&pid=Api&P=0&h=220','neha@gmail.com')


--TABLE MANIPULATION SECTION 
SELECT * FROM [User]


GO 