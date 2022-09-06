----- DAY 1 LAT 1 (15/8/2022)-----

----- Cara menghitung aggregate
select EmployeeID, count (*)as total_order
from Northwind.dbo.orders
group by EmployeeID
order by EmployeeID

select EmployeeID, count (*)as total_order
from Northwind.dbo.orders
group by EmployeeID
order by EmployeeID

---1 Menampilkan Department dari tiap regions
select r.region_id,region_name,count(d.department_id) as totaL_department
from hr.REGIONS r join hr.COUNTRIES c on r.region_id=c.region_id
join hr.LOCATIONS l on c.country_id= l.country_id
join hr.DEPARTMENTS d on l.location_id=d.location_id
group by r.region_id,region_name
order by r.region_id

--2 Menapilkan department tiap country
select c.country_id, country_name, count(d.department_id) as total_department
FROM hr.COUNTRIES c right join hr.LOCATIONS l on c.country_id= l.country_id
right join hr.DEPARTMENTS d on l.location_id=d.location_id
right join hr.EMPLOYEES e on d.department_id=e.department_id
group by c.country_id,country_name
order by c.country_name

---3 Menampilkan employee dari tiap department
select d.department_id,department_name,count(employee_id) as totaL_employee
from hr.departments d left join hr.employees e on d.department_id=e.department_id
group by d.department_id,department_name
order by d.department_name
---- right join depratmen null
---- left join total employe null


---4 menampilkan employee dari tiap regions
select r.region_id,region_name,count(employee_id) as totaL_employee
from hr.REGIONS r join hr.COUNTRIES c on r.region_id=c.region_id
join hr.LOCATIONS l on c.country_id= l.country_id
join hr.DEPARTMENTS d on l.location_id=d.location_id
join hr.EMPLOYEES e on d.department_id=e.department_id
group by r.region_id,region_name
order by r.region_id

--5 menampilkan employe tiap country
select c.country_id, country_name, count(e.employee_id) as total_employee
FROM hr.COUNTRIES c join hr.LOCATIONS l on c.country_id= l.country_id
join hr.DEPARTMENTS d on l.location_id=d.location_id
join hr.EMPLOYEES e on d.department_id=e.department_id
group by c.country_id,country_name
order by c.country_name

--6 menampilkan salary tertinggi tiap department
select d.department_id, department_name, max(j.max_salary) as max_salary
from hr.JOBS as j join hr.EMPLOYEES as e on j.job_id=e.job_id 
join hr.DEPARTMENTS as d on e.department_id=d.department_id
group by d.department_id,d.department_name
order by max_salary desc
---fungsi (desc) untuk mengurutkan dari tertinggi ---


--7 menampilkan salary terendah tiap department
select d.department_id, department_name, min(j.min_salary) as min_salary
from hr.JOBS as j
join hr.EMPLOYEES as e on j.job_id=e.job_id 
join hr.DEPARTMENTS as d on e.department_id=d.department_id
group by d.department_id,d.department_name
order by min_salary asc 
---fungsi (asc) berfungsi untuk mengurutkan dari terendah---

--8 menampilkan salary tertinggi tiap department
select d.department_id, department_name, avg(j.max_salary) as avg_salary 
from hr.JOBS as j
join hr.EMPLOYEES as e on j.job_id=e.job_id 
join hr.DEPARTMENTS as d on e.department_id=d.department_id
group by d.department_id,d.department_name
order by avg_salary asc 

---9. Menampilkan mutasi Pegawai dari tiap department
Select d.department_id, d.department_name, count(e.employee_id) as mutasi /*ini yang di select*/
From hr.job_history as e
Join hr.DEPARTMENTS  as d on d.department_id =e.department_id 
Group by d.department_id,d.department_name /*ini yang di group*/
---- Group by harus sama dengan file yang si select----

---10 Menampilkan jumlah mutasi berdasarkan role 
Select j.department_id,j.job_id, count(j.employee_id) as mutasi_role_job
From hr.DEPARTMENTS as d
Join hr.EMPLOYEES as e on d.department_id = e.department_id
Join hr.JOB_HISTORY as j on e.employee_id = j.employee_id
Group by j.department_id,j.job_id


-- 11.	Informasi jumlah employee yang sering dimutasi
select * from hr.EMPLOYEES where EMPLOYEE_ID in 
(select EMPLOYEE_ID 
from hr.JOB_HISTORY
group by EMPLOYEE_ID
having count(*) >= (select max(t.total) from (
select EMPLOYEE_ID, count(*) as total 
from hr.JOB_HISTORY
group by EMPLOYEE_ID)t))


---12.Informasi jumlah employee berdasarkan role jobs-nya.
Select j.job_id, count(e.employee_id) as jumlah_employe
From hr.DEPARTMENTS as d
Join hr.EMPLOYEES as e on d.department_id = e.department_id
Join hr.JOB_HISTORY as j on e.employee_id = j.employee_id
Group by j.job_id

---13. menampilkan lama kerja tiap department
with cte as (
select
DEPARTMENT_ID,
employee_id,first_name,hire_date,DATEDIFF(YY,HIRE_DATE,GETDATE())as lama_kerja
from hr.EMPLOYEES
where department_id is not null
)
select * from cte a join
(select department_id,max(lama_kerja) as lama_kerja from cte group by DEPARTMENT_ID)b
on a.department_id=b.department_id and a.lama_kerja=b.lama_kerja
order by b.lama_kerja desc


--14.Informasi employee baru masuk kerja di tiap department.
---(Permulaan)
select t.department_id,min(t.lama_kerja) from
(select
department_id,
EMPLOYEE_ID,FIRST_NAME,HIRE_DATE,DATEDIFF(YY,HIRE_DATE,GETDATE())as lama_kerja
from hr.EMPLOYEES
where department_id is not null)t
group by t.department_id

---(Akhir)
select * from (
select 
DEPARTMENT_ID,
EMPLOYEE_ID,FIRST_NAME,HIRE_DATE,DATEDIFF(YY,HIRE_DATE,GETDATE())as lama_kerja
from hr.EMPLOYEES
where DEPARTMENT_ID is not null)a,
(select t.DEPARTMENT_ID,min(t.lama_kerja)as lama_kerja from 
(select 
DEPARTMENT_ID,
EMPLOYEE_ID,FIRST_NAME,HIRE_DATE,DATEDIFF(YY,HIRE_DATE,GETDATE())as lama_kerja
from hr.EMPLOYEES
where DEPARTMENT_ID is not null)t
group by t.DEPARTMENT_ID)b
where a.DEPARTMENT_ID=b.DEPARTMENT_ID and a.lama_kerja=b.lama_kerja

--14.Informasi employee baru masuk kerja di tiap department with common temporal expression
with cte as (
select
DEPARTMENT_ID,
employee_id,first_name,hire_date,DATEDIFF(YY,HIRE_DATE,GETDATE())as lama_kerja
from hr.EMPLOYEES
where department_id is not null
)
select * from cte a join
(select department_id,min(lama_kerja) as lama_kerja from cte group by DEPARTMENT_ID)b
on a.department_id=b.department_id and a.lama_kerja=b.lama_kerja
order by b.lama_kerja asc

--- join yang ada nilainya saja
--- right join  lama kerja null
--- left join bergantung dengan department


--15.Informasi lama bekerja tiap employee dalam tahun dan jumlah mutasi history-nya.
Select distinct e.first_name, e.employee_id,hire_date,
datediff(yy,hire_date,getdate()) as lama_kerja, count(j.job_id) as jumlah_mutasi
From hr.EMPLOYEES e
Join hr.job_history j on e.employee_id = j.employee_id
Group by e.first_name,e.employee_id,e.hire_date 
order by lama_kerja desc
