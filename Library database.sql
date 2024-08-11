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

create table IRBook(
id int not null auto_increment primary key,
std_enroll varchar (250) not null,
std_name varchar (250) not null,
 std_dep varchar (250) not null,
 std_sem varchar (250) not null,
 std_contact bigint not null,
 std_email varchar (250) not null,
 book_name varchar (250) not null,
 book_issue_date varchar (250) not null,
 Book_return_date varchar (250) 
);
