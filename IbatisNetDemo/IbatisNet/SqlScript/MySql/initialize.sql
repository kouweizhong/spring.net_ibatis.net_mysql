CREATE DATABASE nan;
create table nan.person (name VARCHAR(20),sex CHAR,age INT,birthdate DATE );
insert into nan.person (
   name
  ,sex
  ,age
  ,birthdate
) VALUES (
   'Tom'  -- name - IN varchar(20)
  ,'0'  -- sex - IN char(1)
  ,18   -- age - IN int(11)
  ,'1987-09-12'  -- birthdate - IN date
);
