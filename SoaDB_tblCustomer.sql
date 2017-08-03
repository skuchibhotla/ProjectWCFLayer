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