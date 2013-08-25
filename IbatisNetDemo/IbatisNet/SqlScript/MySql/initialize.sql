CREATE DATABASE nan;
create table demo_numbertest (COLUMN_1 decimal,COLUMN_2 decimal,COLUMN_3 decimal,ID char,BLOB1 BINARY,CLOB1 BLOB);
insert into demo_numbertest (
   COLUMN_1
  ,COLUMN_2
  ,COLUMN_3
  ,ID
  ,BLOB1
  ,CLOB1
) VALUES (
   1   -- COLUMN_1 - IN decimal(10,0)
  ,1  -- COLUMN_2 - IN decimal(10,0)
  ,1   -- COLUMN_3 - IN decimal(10,0)
  ,'1'  -- ID - IN char(1)
  ,0   -- BLOB1 - IN binary(1)
  ,0   -- CLOB1 - IN blob
);
