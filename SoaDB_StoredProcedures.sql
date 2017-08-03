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
