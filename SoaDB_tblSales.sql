create table tblSales
(
		Id int primary key,
		CustomerId int,
		Amount float
)

insert into tblSales values (1, 100, 50.4)
insert into tblSales values (2, 200, 18.1)
insert into tblSales values (3, 200, 13.2)
insert into tblSales values (4, 400, 21.1)

select * from tblSales

