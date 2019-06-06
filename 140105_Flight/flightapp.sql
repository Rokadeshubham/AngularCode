use [140105_Flight]
--Aircraft Table
create table AirCraft(AircraftId int primary key,AircraftName varchar(50),Capacity int)

insert into AirCraft values(1,'SpiceJet',350);
insert into AirCraft values(2,'JetAirways',300);
insert into AirCraft values(3,'SpyJet',200);
insert into AirCraft values(4,'Emiretes',400);
insert into AirCraft values(5,'AirIndia',250);
insert into AirCraft values(6,'Jet',350);
select * from AirCraft

--Flight Table


create table Flight(FlightId int primary key,AircraftId int References AirCraft(AircraftId),Capacity int,SourceId int,DestinationId int,TravelDate date,DepartureTime time,ArrivalTime Time)

--Cities Table
create table City(CityId int primary key,CityName varchar(50))

--Passenger Table
create table Passenger(CutomerId int primary key,FirstName varchar(50),LastName varchar(50),Age int,Gender varchar(10))

--Fight Deatails table
create table FlightDetails(CutomerId int References Passenger(CutomerId),FlightId int References Flight(FlightId))




--stored procedures for finding id of city
alter proc CityID(@city varchar(50))
as
begin
select CityId from City where CityName = @city
end


create proc CityID1(@city1 varchar(50))
as
begin
select CityId from City where CityName = @city1
end


exec CityID 'pune'

--proc for inserting into flight

create proc InsertIntoFlight(@AircraftId int,@Capacity int,@SourceId int,@DestinationId int,@Date date,@DepartTime time,@ArrivalTime time)
as
begin
	insert into Flight values(@AircraftId,@Capacity,@SourceId,@DestinationId,@Date,@DepartTime,@ArrivalTime)
end



CREATE proc SearchFlight(@source int,@destination int)
as
begin
	select * from Flight f join AirCraft a 
	on f.AircraftId = a.AircraftId
	where f.SourceId =@source and f.DestinationId =@destination and f.TravelDate = '2019-04-16'
end


--proc to add passenger
create proc AddPassenger(@firstname varchar(50),@lname varchar(50),@age int,@gender varchar(50))
as
begin
	insert into Passenger values(@firstname,@lname,@age,@gender)
end

--finding flightid
