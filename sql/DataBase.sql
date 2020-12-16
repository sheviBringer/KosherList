Create DataBase DBKosherList
go 
use DBKosherList
go

create table Worker_tbl(
codeWorker int primary key identity(0,1),
nameWorker varchar(25),
addressWorker varchar(25),
telWorker varchar(25),
experience int,
dateStart date DEFAULT GETDATE(),
email varchar(50),
mobility כן לא 
);

create table Store_tbl(
codeStore int primary key identity(0,1),
nameStore varchar(25),
addressStore varchar(25),
clasificationStore בחירה מרובה /אולי צריך לעשות טבלה נוספת,
activityTimeStart time,
activityTimeEnd time
);

create table Updates_tbl(
codeStore int  not null,
codeWorker int  not null,
dateVisit date not null DEFAULT GETDATE(),
begginingTime time,
exitingTime time,
remarks varchar(200),
result טוב בינוני גרוע
,
    FOREIGN KEY (codeStore) REFERENCES Store_tbl(codeStore), 
    FOREIGN KEY (codeWorker) REFERENCES Worker_tbl(codeWorker),
    UNIQUE (codeStore, codeWorker)
);

