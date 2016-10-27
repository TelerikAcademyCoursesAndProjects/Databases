USE TelerikAcademy
-- 1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
-- Use a nested SELECT statement.

SELECT FirstName,LastName,Salary
FROM Employees
WHERE Salary=
	(SELECT MIN(Salary) FROM	Employees)

-- 2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

SELECT FirstName, LastName, Salary
FROM Employees
WHERE Salary <
	(SELECT MIN(Salary) FROM Employees) * 1.1
ORDER BY Salary 

-- 3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
-- Use a nested SELECT statement.

SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', e.Salary, d.Name AS 'Department'
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE Salary =
	(SELECT MIN(Salary) 
	 FROM Employees
	 WHERE DepartmentID = e.DepartmentID)
ORDER BY Salary

-- 4. Write a SQL query to find the average salary in the department #1.

SELECT AVG(e.Salary) AS 'Department 1 Average Salary'
FROM Employees e
WHERE e.DepartmentID = 1

-- 5. Write a SQL query to find the average salary in the "Sales" department.

SELECT AVG(e.Salary) AS 'Average Salary In "Sales" Department'
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name= 'Sales' 

-- 6. Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(*) AS 'Number Of Employees In "Sales" Department'
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name= 'Sales' 

-- 7. Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(e.ManagerID) AS 'Number Of Employees That Have Manager'
FROM Employees e
WHERE e.ManagerID IS NOT NULL -- moje i bez tozi posledniqt red poneje po count-a ni vra6ta vsi4ki stoinosti bez NULL!!!

-- 8. Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(*) AS 'Number Of Employees That Don''t Have Manager'
FROM Employees e
WHERE e.ManagerID IS NULL

-- 9. Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name AS 'Department' , AVG(e.Salary) AS 'Average salary'
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

-- 10. Write a SQL query to find the count of all employees in each department and for each town.

SELECT COUNT(*) AS 'Number of employees', d.Name AS 'Employees in Department', t.Name AS 'Employees in town'
FROM Employees e
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name, t.Name
ORDER BY d.Name

-- 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

SELECT m.FirstName + ' ' + m.LastName AS 'Manager Full Name'
FROM Employees e
	JOIN Employees m
		ON e.ManagerID = m.EmployeeID
GROUP BY m.FirstName, m.LastName
HAVING COUNT(m.EmployeeID) = 5
