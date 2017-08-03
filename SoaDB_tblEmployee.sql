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