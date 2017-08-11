create table [dbo].Contacts(
	ContactId int identity not null primary key,
	ContactName varchar(100) not null,
	ContactNo varchar(50) not null,
	AddedOn Datetime not null
)

ALTER DATABASE MyPushNotification SET ENABLE_BROKER

insert into Contacts values('test','123',GetDate())