Create database library;
use library;

Create table NewBook(
bid int NOT NULL auto_increment PRIMARY KEY,
bName Varchar(250) NOT NULL,
bAuthor Varchar(250) NOT NULL,
bPubl varchar(250) NOT NULL,
bpDate varchar(250) NOT NULL,
bPrice bigint NOT NULL,
bQuan bigint NOT NULL
); 

select * from NewBook;

create table NewStudent(
stuid int NOT null auto_increment primary key,
sname varchar(250) not null,
enroll varchar(250) not null,
dep varchar(250) not null,
sem varchar(250) not null,
contact bigint not null,
email varchar(250) not null
);

