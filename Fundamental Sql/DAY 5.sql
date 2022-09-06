select *from sales.ORDERS
select *from hr.EMPLOYEES




select order_id,order_employee_id,x_EmployeeID from sales.ORDERS

-- mengupdate data dari sales.order (order_id,order_employee_id,x_EmployeeID) digabungkan dengan employee_id dari hr.employee
update sales.ORDERS
set order_employee_id = (select order_id,order_employee_id,x_EmployeeID,employee_id from hr.EMPLOYEES e  
join sales.ORDERS o on e.xemp_id = o.x_EmployeeID and e.x_EmployeeID = xx.x_EmployeeID)
from sales.orders  as xx
-- mengupdate data dari sales.order (order_id,order_employee_id,x_EmployeeID) digabungkan dengan employee_id dari hr.employee

-- menampilkan data dari sales.order (order_id,order_employee_id,x_EmployeeID) digabungkan dengan employee_id dari hr.employee
select order_id,order_employee_id,x_EmployeeID,Employee_id from hr.EMPLOYEES e join sales.ORDERS o
on e.xemp_id = o.x_EmployeeID
-- menampilkan data dari sales.order (order_id,order_employee_id,x_EmployeeID) digabungkan dengan employee_id dari hr.employee



Select department_name,max (DATEDIFF(yy,hire_date,GETDATE())) as lama_kerja
from hr.DEPARTMENTS d
right join hr.employees e on d.department_id= e. department_id


select *from sales.ORDERS
select *from hr.EMPLOYEES where xemp_id is not null

--- join select order and hr.employees
select distinct Employee_id
from hr.EMPLOYEES e join sales.ORDERS o on e.xemp_id =o.x_EmployeeID
where xemp_id is not null

-- mengupdate data dari sales.order (order_id,order_employee_id,x_EmployeeID) digabungkan dengan employee_id dari hr.employee
select *from sales.ORDERS

update sales.ORDERS set order_employee_id=null

update so
set order_employee_id = (select distinct Employee_id
from hr.EMPLOYEES e join sales.ORDERS o on e.xemp_id =o.x_EmployeeID
where xemp_id is not null and o.x_EmployeeID=so.x_EmployeeID)
from sales.ORDERS so
-- Batas mengupdate data dari sales.order (order_id,order_employee_id,x_EmployeeID) digabungkan dengan employee_id dari hr.employee


---menampilkan employeID dari nortwhine.dbo
select EmployeeID, count (*) as total_order
from Northwind.dbo.Orders
group by EmployeeID
order by EmployeeID
---menampilkan employeID dari nortwhine.dbo
select order_employee_id,x_EmployeeID, count (*) as total_order
from sales.Orders
group by order_employee_id,x_EmployeeID
order by order_employee_id,x_employeeID


