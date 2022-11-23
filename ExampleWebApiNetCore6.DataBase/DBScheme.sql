USE [master]
GO
/****** Object:  Database [Parking]    Script Date: 4/11/2022 09:03:20 ******/
CREATE DATABASE [Parking]
GO
ALTER DATABASE [Parking] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Parking].[dbo].[sp_fulltext_database] @action = 'enable'
end

GO
USE [Parking]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 4/11/2022 09:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[CarID] [uniqueidentifier] NOT NULL,
	[Plate] [nchar](10) NOT NULL,
	[Driver] [nvarchar](50) NOT NULL,
	[CreatedBy] [uniqueidentifier] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slot]    Script Date: 4/11/2022 09:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slot](
	[SlotID] [uniqueidentifier] NOT NULL,
	[Number] [int] NOT NULL,
	[isEmpty] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/11/2022 09:03:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [uniqueidentifier] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](MAX) NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[LastName] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Slot] ADD  CONSTRAINT [DF_Slot_SlotID]  DEFAULT (newid()) FOR [SlotID]
GO
USE [master]
GO
ALTER DATABASE [Parking] SET  READ_WRITE 
GO
USE [Parking]
GO
create procedure GetCarByPlate
(@Plate [nchar](10))
as
begin
	select Plate, Driver from [Car]
	where Plate = @Plate
end
GO
create procedure SaveUser
(@UserID [uniqueidentifier],
	@Username [nvarchar](50),
	@Password [nvarchar](MAX),
	@Name [nchar](10),
	@LastName [nchar](10))
	as
	begin
		insert into dbo.[User](UserID, Username, [Password],[Name], LastName)values(@UserID, @Username, @Password, @Name, @LastName)
	end
GO

select * from [User]