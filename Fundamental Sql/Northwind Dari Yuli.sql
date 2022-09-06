select FirstName,LastName,DATEADD(YEAR,20,HireDate),8000 salary,  
case when title ='sales Representative' then 'SA_REP' 
	 when title ='Vice President, sales' then 'AD_VP' 
	 when title ='Sales Manager' then 'AC_MGR' 
	  when title ='Inside Sales Coordinator' then 'SH_CLERK' 
	 end title,
CASE when  title ='sales Representative' then 80
	 when title ='Vice President, sales' then 90
	 when title ='Sales Manager' then 110
	  when title ='Inside Sales Coordinator' then 50 
	 end department,
CASE when  title ='sales Representative' then (select min_salary from hr.JOBS where JOB_ID='SA_REP')
	 when title ='Vice President, sales' then 90
	 when title ='Sales Manager' then 110
	  when title ='Inside Sales Coordinator' then 50 
	 end salary
from Northwind.dbo.Employees