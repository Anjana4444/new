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

