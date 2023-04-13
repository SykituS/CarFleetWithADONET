USE [CarFleetDB]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 13.04.2023 16:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](255) NOT NULL,
	[LastName] [varchar](255) NOT NULL,
	[PhoneNumber] [varchar](15) NOT NULL,
	[Email] [nvarchar](255) NOT NULL,
	[Disabled] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 13.04.2023 16:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[PersonID] [int] NOT NULL,
	[RoleID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 13.04.2023 16:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [varchar](255) NULL,
	[Model] [varchar](255) NULL,
	[ProductionYear] [int] NULL,
	[LicensePlate] [varchar](7) NOT NULL,
	[VinNumber] [varchar](17) NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedByID] [int] NOT NULL,
	[UpdatedOn] [datetime] NOT NULL,
	[UpdatedByID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleDescription]    Script Date: 13.04.2023 16:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleDescription](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [int] NULL,
	[Description] [varchar](max) NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedByID] [int] NOT NULL,
	[UpdatedOn] [datetime] NOT NULL,
	[UpdatedByID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleInspection]    Script Date: 13.04.2023 16:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleInspection](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [int] NULL,
	[DateOfInspection] [datetime] NULL,
	[DateOfNextInspection] [datetime] NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedByID] [int] NOT NULL,
	[UpdatedOn] [datetime] NOT NULL,
	[UpdatedByID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleInsurer]    Script Date: 13.04.2023 16:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleInsurer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [int] NULL,
	[Insurer] [varchar](255) NULL,
	[StartDateOfInsurence] [datetime] NULL,
	[EndDateOfInsurence] [datetime] NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedByID] [int] NOT NULL,
	[UpdatedOn] [datetime] NOT NULL,
	[UpdatedByID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleMileage]    Script Date: 13.04.2023 16:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleMileage](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [int] NULL,
	[Mileage] [int] NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedByID] [int] NOT NULL,
	[UpdatedOn] [datetime] NOT NULL,
	[UpdatedByID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehiclePersonHistory]    Script Date: 13.04.2023 16:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehiclePersonHistory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [int] NULL,
	[PersonID] [int] NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedByID] [int] NOT NULL,
	[UpdatedOn] [datetime] NOT NULL,
	[UpdatedByID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleStatus]    Script Date: 13.04.2023 16:00:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [int] NULL,
	[Status] [int] NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedByID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_User_Person] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_User_Person]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Person_Created] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Person_Created]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Person_Updated] FOREIGN KEY([UpdatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Person_Updated]
GO
ALTER TABLE [dbo].[VehicleDescription]  WITH CHECK ADD  CONSTRAINT [FK_VehicleDescription_Person_Created] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehicleDescription] CHECK CONSTRAINT [FK_VehicleDescription_Person_Created]
GO
ALTER TABLE [dbo].[VehicleDescription]  WITH CHECK ADD  CONSTRAINT [FK_VehicleDescription_Person_Updated] FOREIGN KEY([UpdatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehicleDescription] CHECK CONSTRAINT [FK_VehicleDescription_Person_Updated]
GO
ALTER TABLE [dbo].[VehicleDescription]  WITH CHECK ADD  CONSTRAINT [FK_VehicleDescription_Vehicle] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[Vehicle] ([ID])
GO
ALTER TABLE [dbo].[VehicleDescription] CHECK CONSTRAINT [FK_VehicleDescription_Vehicle]
GO
ALTER TABLE [dbo].[VehicleInspection]  WITH CHECK ADD  CONSTRAINT [FK_VehicleInspection_Person_Created] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehicleInspection] CHECK CONSTRAINT [FK_VehicleInspection_Person_Created]
GO
ALTER TABLE [dbo].[VehicleInspection]  WITH CHECK ADD  CONSTRAINT [FK_VehicleInspection_Person_Updated] FOREIGN KEY([UpdatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehicleInspection] CHECK CONSTRAINT [FK_VehicleInspection_Person_Updated]
GO
ALTER TABLE [dbo].[VehicleInspection]  WITH CHECK ADD  CONSTRAINT [FK_VehicleInspection_Vehicle] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[Vehicle] ([ID])
GO
ALTER TABLE [dbo].[VehicleInspection] CHECK CONSTRAINT [FK_VehicleInspection_Vehicle]
GO
ALTER TABLE [dbo].[VehicleInsurer]  WITH CHECK ADD  CONSTRAINT [FK_VehicleInsurer_Person_Created] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehicleInsurer] CHECK CONSTRAINT [FK_VehicleInsurer_Person_Created]
GO
ALTER TABLE [dbo].[VehicleInsurer]  WITH CHECK ADD  CONSTRAINT [FK_VehicleInsurer_Person_Updated] FOREIGN KEY([UpdatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehicleInsurer] CHECK CONSTRAINT [FK_VehicleInsurer_Person_Updated]
GO
ALTER TABLE [dbo].[VehicleInsurer]  WITH CHECK ADD  CONSTRAINT [FK_VehicleInsurer_Vehicle] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[Vehicle] ([ID])
GO
ALTER TABLE [dbo].[VehicleInsurer] CHECK CONSTRAINT [FK_VehicleInsurer_Vehicle]
GO
ALTER TABLE [dbo].[VehicleMileage]  WITH CHECK ADD  CONSTRAINT [FK_VehicleMileage_Person_Created] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehicleMileage] CHECK CONSTRAINT [FK_VehicleMileage_Person_Created]
GO
ALTER TABLE [dbo].[VehicleMileage]  WITH CHECK ADD  CONSTRAINT [FK_VehicleMileage_Person_Updated] FOREIGN KEY([UpdatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehicleMileage] CHECK CONSTRAINT [FK_VehicleMileage_Person_Updated]
GO
ALTER TABLE [dbo].[VehicleMileage]  WITH CHECK ADD  CONSTRAINT [FK_VehicleMileage_Vehicle] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[Vehicle] ([ID])
GO
ALTER TABLE [dbo].[VehicleMileage] CHECK CONSTRAINT [FK_VehicleMileage_Vehicle]
GO
ALTER TABLE [dbo].[VehiclePersonHistory]  WITH CHECK ADD  CONSTRAINT [FK_VehiclePersonHistory_Person_Created] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehiclePersonHistory] CHECK CONSTRAINT [FK_VehiclePersonHistory_Person_Created]
GO
ALTER TABLE [dbo].[VehiclePersonHistory]  WITH CHECK ADD  CONSTRAINT [FK_VehiclePersonHistory_Person_Updated] FOREIGN KEY([UpdatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehiclePersonHistory] CHECK CONSTRAINT [FK_VehiclePersonHistory_Person_Updated]
GO
ALTER TABLE [dbo].[VehiclePersonHistory]  WITH CHECK ADD  CONSTRAINT [FK_VehiclePersonHistory_Vehicle] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[Vehicle] ([ID])
GO
ALTER TABLE [dbo].[VehiclePersonHistory] CHECK CONSTRAINT [FK_VehiclePersonHistory_Vehicle]
GO
ALTER TABLE [dbo].[VehicleStatus]  WITH CHECK ADD  CONSTRAINT [FK_VehcileStatus_Person_Created] FOREIGN KEY([CreatedByID])
REFERENCES [dbo].[Persons] ([ID])
GO
ALTER TABLE [dbo].[VehicleStatus] CHECK CONSTRAINT [FK_VehcileStatus_Person_Created]
GO
ALTER TABLE [dbo].[VehicleStatus]  WITH CHECK ADD  CONSTRAINT [FK_VehcileStatus_Vehicle] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[Vehicle] ([ID])
GO
ALTER TABLE [dbo].[VehicleStatus] CHECK CONSTRAINT [FK_VehcileStatus_Vehicle]
GO
