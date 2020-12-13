# ContactAPII

DB Queries
-----------
create table Contacts
(
ContactID int primary key identity(1,1),
Name  varchar(25),
Email varchar(25),
Phone varchar(15),
Address varchar(30)
)

insert into Contacts values('Varathan','varathan@gmail.com','9965982578','Chennai')
insert into Contacts values('Gowtham','gowtham@gmail.com','9982578123','Hydrabad')
insert into Contacts values('Bala','bala@gmail.com','9982578123','Pondy')
insert into Contacts values('Thennavan','thenz@gmail.com','9982578123','Coimbatore')
insert into Contacts values('Whinny','whinny@gmail.com','9982578123','USA')
insert into Contacts values('Rashford','rashford@gmail.com','9982578123','England')

Prerequisite
-------------
API --> connection string needs to be changed
Angular --> baseUrl variable from ContactService.ts needs to be changed
