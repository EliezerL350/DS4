-- 1
select * from Products

-- 2
select ProductID, ProductName, UnitPrice from Products

-- 3
select ProductID, ProductName, UnitPrice from Products where UnitPrice > 15

-- 4
select ProductID, ProductName, UnitPrice from Products where UnitPrice >= 15 and UnitPrice <= 50

-- 5
select ProductID, ProductName, UnitPrice from Products where UnitPrice between 15 and 50

-- 6
select ProductID, ProductName, UnitPrice from Products where not UnitPrice > 15

-- 7
select ProductID, ProductName, UnitPrice from Products where ProductID > 50 or UnitPrice < 10

-- 8
select EmployeeID, LastName from Employees where LastName like 'D%'

-- 9
select EmployeeID, LastName from Employees where LastName like '%N'

-- 10
select EmployeeID, LastName from Employees where Title like '%Sales%'

-- 11
select EmployeeID, LastName from Employees where not LastName like 'D%' 

-- 12
select ProductID, ProductName, UnitPrice from Products order by ProductID asc

-- 13
select ProductID, ProductName, UnitPrice from Products order by ProductID desc

-- 14
select distinct OrderID from [Order Details]

-- 15
select top 5 OrderID, ProductID, Quantity from [Order Details]

-- 16
select top 5 percent OrderID from [Order Details]

-- 17
select CategoryName 'Categorias' from Categories

-- 18
select OrderID, OrderDate, ShippedDate, ShippedDate from Orders

-- 19
select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID

-- 20
select ProductName, CompanyName, ContactName from Products p full join Suppliers s on p.SupplierID = s.SupplierID
