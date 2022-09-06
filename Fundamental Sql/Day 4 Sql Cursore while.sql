----T-SQL (di sql server) transaction squel-------
----P-SQL (di oracle)------------
@= disebut a mole

--pertama mmebuat variabel dengan declarate
-- print = untuk menampilkan variabel

---1 variabel
declare @n int=1;
print @n

---1 variabel + variabel 10
declare @n int=1;
set @n=@n+10;
print @n;
select @n as result;

---get from table
--- jika variabel dari tabel int, maka kita harus buat variabel dengan tipe int dst
select*from sales.CUSTOMERS

---- Memasukan variabel T sql dari sales_customer kedalam @cust_id
---- harus dijalankan semua (batas atas)

declare @cust_id int;
declare @cust_name nvarchar(40);
select @cust_id=cust_id, @cust_name=cust_name 
from sales.customers
where cust_id=1;
select @cust_id as customer_id, @cust_name as customer_name 

---- harus dijalankan semua (batas bawah)

----cursor----
---- cursor_category = adalah variabel tanpa simbol x
----
declare @cate_id int;
declare @cate_name nvarchar(40);
declare cursor_category cursor FORWARD_ONLY READ_ONLY FOR
	select top(3) cate_id,cate_name from sales.CATEGORIES;
begin
	--- open cursor
	open cursor_category;
	


	---close cursor
	close cursor_category;
	---- hapus cursor di memory database
	deallocate cursor_category;
end;




