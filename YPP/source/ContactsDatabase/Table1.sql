CREATE TABLE [dbo].[Table1]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [First Name] TEXT NOT NULL, 
    [Last Name] TEXT NOT NULL, 
    [Street Name] TEXT NOT NULL, 
    [House Number ] INT NOT NULL, 
    [Apartment Number] INT NULL, 
    [Postal Code ] TEXT NOT NULL, 
    [Town ] TEXT NOT NULL, 
    [Phone Number ] INT NOT NULL, 
    [Date of Birth] DATE NOT NULL
)
