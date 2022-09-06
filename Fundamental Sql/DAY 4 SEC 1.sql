----- DAY 4 (18/8/2022)
---  MENAMPILKAN DATA SUPLIERS DAN DBO SUPPLIER
select*from sales.SUPPLIERS
select*from.northwind.dbo.suppliers

---range date
select*
from sales.ORDERS
where order_date between '1996-07-04' and '1996-07-10'

---- order primary key atau unik jangan di order karena berat di ram
---  pagination (untuk test API (untuk memecahkan data)) paging artinya pecah atau memecah data
select* from sales.ORDERS

---- MENAMPILKAN SALES OTRDER DARI TABEL NO 0 KE 5
select* from sales.ORDERS
order by order_id
offset 0 row fetch next 5 rows only

---- MENAMPILKAN SALES OTRDER DARI TABEL NO 5 KE 10
select* from sales.ORDERS
order by order_id
offset 5 row fetch next 5 rows only

--- top (artinya mengambil tabel teratas)
select top(5) *from sales.ORDERS



