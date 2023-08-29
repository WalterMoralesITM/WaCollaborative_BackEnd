BEGIN

DECLARE @SQLString NVARCHAR(MAX); 

	IF NOT EXISTS (SELECT * FROM sys.databases d WHERE d.name = 'WaCollaborative')
	BEGIN
		SET @SQLString = N' USE master CREATE DATABASE [WaCollaborative];';  

		EXECUTE sp_executesql @SQLString

		SET @SQLString = N' USE WaCollaborative';  
		EXECUTE sp_executesql @SQLString
		PRINT 'CREATE DATABASE';
	END
	ELSE
	BEGIN
		PRINT 'DATABASE EXISTS';
	END

	IF NOT EXISTS (SELECT * FROM sys.schemas s WHERE s.name = 'Parameters')
	BEGIN
		SET @SQLString = N'CREATE SCHEMA [Parameters];';  

		EXECUTE sp_executesql @SQLString
		PRINT 'CREATE SCHEMA';
	END
	ELSE
	BEGIN
		PRINT 'SCHEMA EXISTS';
	END

	IF NOT EXISTS (SELECT * FROM sys.tables AS t INNER JOIN sys.schemas AS s ON s.schema_id = t.schema_id WHERE t.name = 'Status'AND s.name = 'Parameters')
	BEGIN
		SET @SQLString = N'CREATE TABLE [Parameters].[Status]([Id] [int] IDENTITY(1,1) NOT NULL, [Name] [nvarchar](50) NOT NULL, [Shortname] [nvarchar](20) NOT NULL, CONSTRAINT UC_Status_Name UNIQUE (Name), CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED ( [Id] ASC)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY] ) ON [PRIMARY];';  
		EXECUTE sp_executesql @SQLString
		PRINT 'CREATE TABLE';
	END
	ELSE
	BEGIN
		PRINT 'TABLE EXISTS';
	END

END

