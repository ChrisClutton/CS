CREATE TABLE [dbo].[Log]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Initials] VARCHAR(50) NULL, 
    [Keyword] VARCHAR(50) NULL, 
    [Time] DATETIME2 NULL
)
