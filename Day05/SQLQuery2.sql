create database FISAssignments

use FISAssignments

create table Products
(
	ID int not null primary key,
	Name varchar(30),
	Price float,
	Description varchar(50),
	IsActive bit
)

insert into Products values(101,'Headphones',230.50,'Use to listen music',0)

select * from Products

select * from Products where ID=101

create table OrderData
(
	OrderID int not null primary key,
	CustomerName varchar(50),
	OrderDate Date,
	OrderAmount float
);

select * from OrderData

insert into OrderData values(101,'Swapnil','2021-09-24',300)