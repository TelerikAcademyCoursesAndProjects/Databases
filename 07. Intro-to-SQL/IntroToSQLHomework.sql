-- 1. Structured Query Language) is a special-purpose programming language designed for managing data
-- held in a relational database management system (RDBMS)
-- DML is abbreviation of Data Manipulation Language. It is used to retrieve, store, 
-- modify, delete, insert and update data in database.
-- Examples: SELECT, UPDATE, INSERT statements
-- DDL is abbreviation of Data Definition Language. It is used to create and modify the structure 
-- of database objects in database.
-- Examples: CREATE, ALTER, DROP statements

-- 2. Transact-SQL (T-SQL) is Microsoft's and Sybase's proprietary extension to SQL. SQL, 
-- the acronym for Structured Query Language, is a standardized computer language that was 
-- originally developed by IBM for querying, altering and defining relational databases, 
-- using declarative statements.

-- Queries can be executed one at the time by selecting the relevant text and pressing F5

-- 4. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
USE TelerikAcademy

SELECT *
FROM Departments 

-- 5. Write a SQL query to find all department names.

SELECT Name
FROM Departments 

-- 6. Write a SQL query to find the salary of each employee.

SELECT FirstName, LastName, Salary
FROM Employees 

-- 7. Write a SQL to find the full name of each employee.

SELECT FirstName,MiddleName, LastName
FROM Employees   

-- 8. Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".

SELECT FirstName + '.' + LastName + '@telerik.com'  AS 'Full Email Addresses'
FROM Employees 

-- 9. Write a SQL query to find all different employee salaries.

SELECT FirstName + '.' + LastName + '@telerik.com'  AS 'Full Email Addresses'
FROM Employees 