----- DAY 3 SEC 3_LATIHAN 3 (17/8/2022)-----

select *from sales.ORDERS
select *from sales.CUSTOMERS

---- FILTER SALES.ORDERS DENGAN HANYA MENAMPILKAN order_id,order_cust_id,x_CustomerID
select order_id,order_cust_id,x_CustomerID from sales.ORDERS

-- menampilkan data dari sales.order (order_id,order_employee_id,x_EmployeeID) digabungkan dengan employee_id dari hr.employee
select order_id,order_cust_id,x_CustomerID,cust_id from sales.CUSTOMERS e join sales.ORDERS o
on e.cust_code = o.x_CustomerID
-- menampilkan data dari sales.order (order_id,order_employee_id,x_EmployeeID) digabungkan dengan employee_id dari hr.employee

select *from sales.ORDERS
select *from sales.CUSTOMERS where cust_id is not null

select distinct cust_id
from sales.CUSTOMERS e join sales.ORDERS o on e.cust_code =o.x_CustomerID
where cust_code is not null

update so
set order_cust_id = (select distinct cust_id
from sales.CUSTOMERS e join sales.ORDERS o on e.cust_code =o.x_CustomerID
where cust_code is not null and o.x_CustomerID=so.x_CustomerID)
from sales.ORDERS so

select *from sales.ORDERS
select *from sales.CUSTOMERS where cust_id is not null

select order_id,order_cust_id,x_CustomerID from sales.ORDERS
select *from sales.ORDERS

select order_id,order_cust_id,x_CustomerID from sales.ORDERS

select order_cust_id,x_CustomerID, count (*) as total_order
from sales.Orders
group by order_cust_id,x_CustomerID
order by order_cust_id,x_CustomerID

