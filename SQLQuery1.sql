CREATE TABLE NAMES 
(
   ID INT NOT NULL IDENTITY(1,1),
   FirstName VARCHAR(100),
   SecondName VARCHAR(100)
)

SELECT * FROM Names
INSERT INTO Names (FirstName, SecondName) VALUES ('Sadia','Afrin')