USE [140105_Flight]
GO
/****** Object:  StoredProcedure [dbo].[AddPassenger]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AddPassenger](@firstname varchar(50),@lname varchar(50),@age int,@gender varchar(50))
as
begin
	insert into Passenger values(@firstname,@lname,@age,@gender)
end

GO
/****** Object:  StoredProcedure [dbo].[CityID]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CityID](@city varchar(50))
as
begin
select CityId from City where CityName = @city
end
GO
/****** Object:  StoredProcedure [dbo].[CityID1]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CityID1](@city1 varchar(50))
as
begin
select CityId from City where CityName = @city1
end
GO
/****** Object:  StoredProcedure [dbo].[InsertIntoFlight]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertIntoFlight](@AircraftId int,@Capacity int,@SourceId int,@DestinationId int,@Date date,@DepartTime time,@ArrivalTime time)
as
begin
	insert into Flight values(@AircraftId,@Capacity,@SourceId,@DestinationId,@Date,@DepartTime,@ArrivalTime)
end
GO
/****** Object:  StoredProcedure [dbo].[SearchFlight]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[SearchFlight](@source int,@destination int)
as
begin
	select * from Flight f join AirCraft a 
	on f.AircraftId = a.AircraftId
	where f.SourceId =@source and f.DestinationId =@destination and f.TravelDate = '2019-04-16'
end
GO
/****** Object:  Table [dbo].[AirCraft]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AirCraft](
	[AircraftId] [int] NOT NULL,
	[AircraftName] [varchar](50) NULL,
	[Capacity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AircraftId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[City]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[City](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [varchar](50) NULL,
 CONSTRAINT [PK__City__F2D21B76C8523C8F] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Flight]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flight](
	[FlightId] [int] IDENTITY(1,1) NOT NULL,
	[AircraftId] [int] NULL,
	[Capacity] [int] NULL,
	[SourceId] [int] NULL,
	[DestinationId] [int] NULL,
	[TravelDate] [date] NULL,
	[DepartureTime] [time](7) NULL,
	[ArrivalTime] [time](7) NULL,
 CONSTRAINT [PK__Flight__8A9E14EED7F1EBBF] PRIMARY KEY CLUSTERED 
(
	[FlightId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FlightDetails]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FlightDetails](
	[CutomerId] [int] NOT NULL,
	[FlightId] [int] NOT NULL,
 CONSTRAINT [PK_FlightDetails] PRIMARY KEY CLUSTERED 
(
	[CutomerId] ASC,
	[FlightId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Passenger]    Script Date: 4/15/2019 1:28:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Passenger](
	[CutomerId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Age] [int] NULL,
	[Gender] [varchar](10) NULL,
 CONSTRAINT [PK__Passenge__323028E0CCF522FB] PRIMARY KEY CLUSTERED 
(
	[CutomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Flight]  WITH CHECK ADD  CONSTRAINT [FK__Flight__Aircraft__1273C1CD] FOREIGN KEY([AircraftId])
REFERENCES [dbo].[AirCraft] ([AircraftId])
GO
ALTER TABLE [dbo].[Flight] CHECK CONSTRAINT [FK__Flight__Aircraft__1273C1CD]
GO
ALTER TABLE [dbo].[FlightDetails]  WITH CHECK ADD  CONSTRAINT [FK__FlightDet__Cutom__1FCDBCEB] FOREIGN KEY([CutomerId])
REFERENCES [dbo].[Passenger] ([CutomerId])
GO
ALTER TABLE [dbo].[FlightDetails] CHECK CONSTRAINT [FK__FlightDet__Cutom__1FCDBCEB]
GO
ALTER TABLE [dbo].[FlightDetails]  WITH CHECK ADD  CONSTRAINT [FK__FlightDet__Fligh__20C1E124] FOREIGN KEY([FlightId])
REFERENCES [dbo].[Flight] ([FlightId])
GO
ALTER TABLE [dbo].[FlightDetails] CHECK CONSTRAINT [FK__FlightDet__Fligh__20C1E124]
GO
