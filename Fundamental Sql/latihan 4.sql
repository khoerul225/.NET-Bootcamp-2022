SELECT *FROM sales.ORDERS WHERE order_id=11039
SELECT *FROM sales.ORDERS_DETAIL WHERE order_id=11039
SELECT *FROM sales.ORDERS WHERE order_shipPED_DATE IS NULL



/*
select *from  SALES.ORDERS
select *from  sales.PRODUCTS
*/
 SALES.ORDERS

--create procedure sales.proc_update_sum_order as 

declare @order_id int;
declare @total_price money;
declare @total_quantity smallint;
declare @order_status nvarchar(40)='shipped';


declare cursor_order CURSOR FORWARD_ONLY READ_ONLY FOR
	select top(5) order_id from sales.ORDERS where order_shipped_date is null;
begin
	--- open cursor
	open cursor_order;
	---prosess and fetch new row untill no more row available
	while @@FETCH_STATUS = 0
	begin
		fetch next 
		from cursor_order
		into @order_id;
		
		----sum-----
		select @total_price = SUM(ordet_price), @total_quantity = sum(ordet_quantity) from sales.ORDERS_DETAIL where ordet_order_id=@order_id;
		----Bagian update

		 
		update sales.ORDERS
		set order_subtotal = @total_price,order_total_qty = @total_quantity,@order_status = order_status 
		where order_id=@order_id
	
		-----select @
		select @order_id as order_id, @total_price as order_total, @total_quantity as order_quantity, @order_status as order_status;
		end
	---close cursor
	close cursor_order;

	---- hapus cursor di memory database
	deallocate cursor_order;
end;



/*
STEP STEP UPDATE DATA MENGGUNAKAN CURSOR
1. LOOP CURSOR SALES.ORDERS
2. SUM (PRICE),SUM(QUANTITY) FROM SALES.ORDERS.DETAIL
3. UPDATE SALES.ORDERS
*/