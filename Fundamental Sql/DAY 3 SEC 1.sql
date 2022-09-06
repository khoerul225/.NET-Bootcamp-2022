----- DAY 3 SEC 1 (17/8/2022)-----

----- Kodingan Ke 1
select* from sales.CUSTOMERS
select* from Northwind.dbo.Orders

----- Kodingan Ke 2
select* from hr.EMPLOYEES
select* from Northwind.dbo.Employees

---kodingan 3
select* from hr.EMPLOYEES

--- Cara Menampilkan Data dengan atribut (MAPPING)
select FirstName,LastName,dateadd(year,20,HireDate), HireDate,
case when title='Sales Representative' then 'SA_REP'
	when title='Vice President, Sales' then 'AD_VP'
	when title='Sales Manager' then 'AC_MGR'
	when title ='Inside Sales Coordinator' then 'SH_CLERK'
end title,
case when title='Sales Representative' then 80
	when title='Vice President, Sales' then 90
	when title='Sales Manager' then 110
	when title ='Inside Sales Coordinator' then 50
end department,
case when title='Sales Representative' then (select min_salary from hr.JOBS where job_id='SA_REP')
	when title='Vice President, Sales' then 90
	when title='Sales Manager' then 110
	when title ='Inside Sales Coordinator' then 50
end salary
from Northwind.dbo.Employees
--- Akhir Cara Menampilkan Data dengan atribut

select *from hr.EMPLOYEES

alter table  hr.EMPLOYEES add xemp_id int

select * from hr.EMPLOYEES where email is null and phone_number is null and manager_id is null 
and commission_pct is null

delete from hr.EMPLOYEES where email is null and phone_number is null and manager_id is null 
and commission_pct is null

DBCC CHECKIDENT ('sales.categories',RESEED,0);
GO


--- Cara Menampilkan Data dengan atribut (MAPPING) dengan inisial t

insert into hr.EMPLOYEES(t.xemp_id,first_name,last_name,hire_date,job_id,department_id,salary)
select t.*,(select min_salary from hr.JOBS where job_id=t.title) as salary from (
select employeeid,FirstName,LastName,dateadd(year,20,HireDate)HireDate,
case when title='Sales Representative' then 'SA_REP'
	when title='Vice President, Sales' then 'AD_VP'
	when title='Sales Manager' then 'AC_MGR'
	when title ='Inside Sales Coordinator' then 'SH_CLERK'
end title,
case when title='Sales Representative' then 80
	when title='Vice President, Sales' then 90
	when title='Sales Manager' then 110
	when title ='Inside Sales Coordinator' then 50
end department
from Northwind.dbo.Employees)t
--- Akhir Cara Menampilkan Data dengan atribut

select *from dbo.Orders
