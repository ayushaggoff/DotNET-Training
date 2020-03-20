create database EmployeeDB
go

use EmployeeDB
go

create table Employees
(
	ID int primary key identity,
	FirstName nvarchar(50),
	LastName nvarchar(50),
	Gender nvarchar(50),
	Salary int
)
go

insert into Employees values('Ayush','Aggarwal','Male',1200000)
insert into Employees values('Aashish','jain','Male',1000000)
insert into Employees values('Prabhat','kumar','Male',700000)
insert into Employees values('mansi','jain','Feale',700000)
insert into Employees values('arif','a','Male',800000)
go