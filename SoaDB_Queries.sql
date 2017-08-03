Create Database SoaDB

Use SoaDB

create table tblEmployee
(
	empno int primary key,
	ename varchar(20),
	mgr int
);

insert into tblEmployee (empno,mgr,ename) values(2000, 1000, 'Anne O''Hara')
insert into tblEmployee (empno,mgr,ename)values(3000, 1000, 'Christian Thomas')
insert into tblEmployee (empno,mgr,ename)values(4000, 1000, 'Paul Lawson')
insert into tblEmployee (empno,mgr,ename)values(5000, 2000, 'Nathaniel Béringer')
insert into tblEmployee (empno,mgr,ename)values(6000, 2000, 'Jean-Marie Graham')
insert into tblEmployee (empno,mgr,ename)values(7000, 4000, 'Elizabeth Taylor II')

select * from tblEmployee

create table tblCustomer
(	CustomerId int primary key,
	CustorName varchar(50),
	Address varchar(50),
	EmployeeId int
);

insert into tblCustomer values(100, 'Liz Johnson','New York', 5000)
insert into tblCustomer values(200, 'Margaret Potter','Canada', 7000)
insert into tblCustomer values(300, 'Mark Edison','Chikago' ,7000)
insert into tblCustomer values(400, 'Kylie Potter','New Jercy', 7000)

select * from tblCustomer

create procedure spGetEmployees
as
	select * from tblEmployee

create proc spGetCustomers
as
	select * from tblCustomer

create proc spGetSales
as
	select * from tblSales

create proc spAddEmployee ( @empno int, @ename varchar(20), @mgr int )
as
begin
	insert into tblEmployee values ( @empno, @ename, @mgr );
end;

create proc spEditEmployee(@empno int, @ename varchar(20), @mgr int )
as
begin
	update tblEmployee set ename=@ename, mgr=@mgr where empno=@empno;
end;

create proc spDeleteEmployee(@empno int )
as
	delete from tblEmployee where empno=@empno;



