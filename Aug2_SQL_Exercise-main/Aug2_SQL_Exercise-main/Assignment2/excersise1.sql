use EmpSample_#OK
go

--query 1 write a query to get a list of employees who have a one part name

select * from tblEmployees
where Name NOT LIKE '% %'
go


--q2 
select emp.Name
from dbo.tblEmployees emp
where emp.Name like '[a-z]%[ ][a-z]%[ ][a-z]%' and emp.Name not like '[a-z]%[ ][a-z]%[ ][a-z]%[ ][a-z]%';


--q3 first middle or last name as ram

select * from tblEmployees
where Name like 'Ram %'
or Name like '% Ram %'
or Name like '% Ram'
go

--q4 bitwise operator 
select EmployeeNumber, Name, CentreCode
from dbo.tblEmployees 
where CentreCode = 65 or CentreCode = 11;

--4.2

select COUNT(*)
from tblEmployees 
where (CategoryCode = 65 or CentreCode = 11) and ((CategoryCode <> 65 and CentreCode <> 11));  

--4.3

select EmployeeNumber, Name, CentreCode, CategoryCode
from tblEmployees
where CategoryCode = 12 and CentreCode = 4;

--4.4

select EmployeeNumber, Name, CentreCode, CategoryCode
from dbo.tblEmployees 
where (CategoryCode=12 and CentreCode=4)or (CategoryCode=13 and CentreCode=1);

--4.5

select EmployeeNumber, Name
from dbo.tblEmployees 
where EmployeeNumber = 127 or EmployeeNumber = 64;

--4.6

select EmployeeNumber,Name
from dbo.tblEmployees 
where (CategoryCode = 127 and CentreCode <> 64) or ((CategoryCode <> 127 and CentreCode = 64));

--4.7

select EmployeeNumber,Name
from dbo.tblEmployees 
where (CategoryCode = 127 and CentreCode <> 128) or ((CategoryCode <> 127 and CentreCode = 128));

--4.8

select EmployeeNumber, Name
from dbo.tblEmployees 
where EmployeeNumber = 127 and AreaCode = 64;

--4.9

select EmployeeNumber, Name
from dbo.tblEmployees 
where EmployeeNumber = 127 and AreaCode = 128;



--q5 which returns data in all columns from the table tblcenter

select * from tblCentreMaster
go

-- q6 which gives employee types in the organization

select distinct EmployeeType from tblEmployees

--q7.1 greather than 3000
select Name,FatherName,DOB from tblEmployees
where PresentBasic>3000
go

--q7.2 lessthan 3000
select Name,FatherName,DOB from tblEmployees
where PresentBasic<3000

--q7.3 between 3000 and 5000

select Name,FatherName,DOB from tblEmployees
where PresentBasic between 3000 and 5000;

-- q8 employee ends with with khan

select * from tblEmployees
where Name like '% khan';

--q8.2

select * from tblEmployees
where Name like '%chandra';

--q 8.3

select * from tblEmployees
where Name like '[a-t][.]Ramesh';