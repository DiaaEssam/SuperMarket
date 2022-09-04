--use Smarket2

--a- Most Bought Prouduct ///////////////DONE

-- With number of people bought it not the quantity


--Counts will count how many people bought this product.....

with counts as (select  p.pname,o.product_id, count(distinct o.customer_id) as number_of_customers
from [order] o 
join product p 
on  o.product_id = p.product_id
group by o.product_id,p.pname) 

select  pname,product_id,number_of_customers  from
counts
where number_of_customers = (select max(number_of_customers) from counts)






--b-Never Bought (Need a Parameter) //Doneee

--Show Product that hasnt been bought For a specific Month...


select * 
 from product 
 where product_id not in (select product_id from [order] 
 where datepart(year, ORDER_DATE)= datepart(year,'2015/08/15') 
 and datepart(Month, ORDER_DATE)= datepart(month,'2015/08/15'))




--e-Food/Electric appliances // Doneeee



select top(1) WITH TIES pg_name, number_purchased
from product_group
where pg_id in (1,5)
order by number_purchased desc




--d-Customer of the Month  //Done

--Highest purchase in that month....

select fname,lname 
from CUSTOMER as c
join
(select top(1) with ties CUSTOMER_id ,sum(purchasing) as purchase
from [order]
where  datepart(month,GETDATE())=datepart(month,ORDER_DATE) 
and datepart(year,GETDATE())=datepart(year,ORDER_DATE)
group by CUSTOMER_ID
order by purchase desc) n
on c.CUSTOMER_ID=n.CUSTOMER_ID



--c-Customer Did not buy any product since 1 year //Done


select  c.fname as First_Name,c.lname as Last_Name 
from customer as c
where c.customer_id not in (select customer_id from [order]
where order_date >= DATEADD(year,-1,GETDATE()))


--f-Retrive All Information Prouducts with number of customers who bought it // Doneeee




select product.*,n.number_of_customers from product 
join (select P.PRODUCT_ID ,count(distinct o.customer_id) 
as number_of_customers from PRODUCT AS P left join[order] 
as o on p.PRODUCT_ID=o.PRODUCT_ID group by p.PRODUCT_ID) n
on n.PRODUCT_ID = PRODUCT.PRODUCT_ID












select * from dbo.[order]

select * from dbo.[ADMIN]

select * from PRODUCT

select * from CUSTOMER

Select * from PRODUCT_GROUP







--Showing a list of frequent customers to give them Discount....

--People who ordered the most 

select * from customer as c join 
(select * from (select CUSTOMER_ID,count(order_id2)as number_of_orders from [ORDER]
group by CUSTOMER_ID) A
where a.number_of_orders=( 
select max(number_of_orders) from( 
select CUSTOMER_ID,count(order_id2)as number_of_orders from [ORDER] 
group by CUSTOMER_ID)n)) S on c.customer_id=s.customer_id

















--Update PRODUCT set PG_ID = 5 where PRODUCT_ID = 4






















