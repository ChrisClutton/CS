CREATE TABLE [dbo].[Log]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Initials] VARCHAR(3) NULL, 
    [Keyword] VARCHAR(25) NULL, 
    [Time] DATETIME NULL
)
