--- Soal Nomer 1---
---Buat query untuk menampilkan jumlah person di tiap region---

select c.CountryRegionCode,c.name,count(pp.PersonType) as totaL_person
from Person.CountryRegion c
full outer join Person.StateProvince s on c.CountryRegionCode=s.CountryRegionCode
full outer join Sales.SalesTerritory st on s.TerritoryID= st.TerritoryID
full outer join Sales.Customer sc on st.TerritoryID= sc.TerritoryID
full outer join Person.Person pp on sc.CustomerID=pp.BusinessEntityID
group by c.CountryRegionCode,c.Name

--- Soal Nomer 2---
---Tampilkan jumlah person berdasarkan person type nya---

select 
CASE
	WHEN PersonType = 'IN' THEN 'Individual Customer'
	WHEN PersonType = 'EM' THEN 'Employee'
	WHEN PersonType = 'SP' THEN 'Sales Person' 
	WHEN PersonType = 'SC' THEN 'Store Contact'
	WHEN PersonType = 'VC' THEN 'Vendor Contact'
	WHEN PersonType = 'GC' THEN 'General Contact'
end as PersonType,
count(PersonType) as totaL_person
from Person.Person
group by PersonType
order by totaL_person asc

