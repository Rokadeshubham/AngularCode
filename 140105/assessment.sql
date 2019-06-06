

use [140105]


create table Category(CategoryID int identity(1,1), CategoryName varchar(50) primary key,CategoryDescription varchar(50))

insert into Category values('Clothing','All wearables comes under that');
select * from Category

/*I have created categoryname as foreign key in database diagrm*/
create table Product(ProductID int identity(1,1) primary key,ProductName varchar(50),CategoryName varchar(50),ProductPrice int,Quantity int )
insert into Product values('Shirt','Clothing',120,10);
insert into Product values('Pant','Clothing',100,10);
insert into Product values('Milk','Beverages',12,1);
insert into Product values ('cycle','vehicle',23,12);
select * from product


/*I have created ProductID as foreign key in database diagrm*/
create table OrderDetails(OrderId int identity(1,1) primary key,ProductID int,Quantity int,DateOfOrdering date,TotalCost int)
insert into OrderDetails values(1,10,'2015-05-21',1000)

/*Procedure for insert into category*/
create proc sp_insertCategory(@CategoryName varchar(50),@CategoryDesc varchar(50))
as
begin
	insert into Category values(@CategoryName,@CategoryDesc);
end

/*Procedure for insert into category*/

create proc sp_insertProduct(@ProductName varchar(50),@Category varchar(50),@Price int,@Quantity int)
as
begin

	insert into Product values(@ProductName,@Category,@Price,@Quantity)
end


exec sp_insertProduct 'ss','beverages',12,11


create proc sp_searchByDate(@Date date)
as
begin
select * from product p join Category c on p.CategoryName = c.CategoryName 
join OrderDetails o on o.ProductID = p.ProductID
where o.DateOfOrdering LIKE '%@Date%'
end

create proc Price(@Name varchar(50))
as
begin
	select ProductPrice from Product where ProductName = @Name
end

