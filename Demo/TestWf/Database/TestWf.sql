use master 
go 

drop database if exists TestWF
create database  TestWF 
go

use TestWF
go


drop table if exists Student 
create table Student 
(
	Id	int	primary	key	identity,
	FirstName	nvarchar(50),
	LastName	nvarchar(50),
	Gender	bit,
	Dob date
)
go

insert into Student 
(
	FirstName, LastName, Gender, Dob
)
values
(
	N'Nguyen', N'Hoang', 1, '2001-07-28'
)
go 10