use SystemERP_DB
select c.Id, c.BusinessName, c.BusinessName, d.Description, c.DocumentNumber, c.Address, ci.Name, 
c.PostalCode, st.Name, co.Denomination, c.CellPhoneNumber, c.Email, c.IsActive, c.CreatedOn
from Clients c
left join DocumentTypes d on c.DocumentTypeId = d.Id 
left join Cities ci on c.CityId = ci.Id
left join States st on c.StateId = st.Id 
left join Countries co on c.CountryId = co.Id
where c.IsOnColppy = 0 

select Description from SubCategories
where CategoryId = 11
order by Description asc

select top 100 p.id, p.Description, p.SubCategoryId, sub.Description, cat.Description from Products p
left join SubCategories sub on p.SubCategoryId = sub.Id
left join Categories cat on sub.CategoryId = cat.Id

select * from Clients 
order by DocumentNumber desc


where DocumentNumber is not null


where DocumentTypeId like 25
select * from DocumentTypes


select * from Categories
select * from SubCategories

select * from Operations
select * from UnitMeasures
select * from ProductFeatures

and d.Description like 'DNI' or d.Description like 'CUIT' and c.DocumentNumber is not null
order by DocumentNumber desc

select distinct(co.Denomination), from Clients c
left join Countries co on co.Id = c.CountryId

select DocumentNumber from Clients
ordey by DocumentNumber asc



UPDATE Providers
SET IsOnColppy = 0

ALTER TABLE Products ADD IsOnColppy bit

UPDATE Providers SET IsOnColppy = 0 where BusinessName like 1

select distinct count(BusinessName) from Providers


select Description, SubCategoryId from Products

select * from SubCategories

select * from Categories

--CATEGORIAS PRODUCTOS	
select p.Description as 'PRODUCTO', sub.Description as 'SUB CATEGORIA', cat.Description as 'CATEGORIA' from Products p
inner join SubCategories sub on p.SubCategoryId = sub.Id
inner join Categories cat on sub.CategoryId = cat.Id

--CAMPOS ALTA PRODUCTO
select pro.Code, pro.Description, pro.Observation, pro.Minimum, '' as 'ultimoPrecioCompra',
pri.PriceArg as 'precioVenta / PriceArg', '' as 'ctaInventario', '' as 'ctaCostoVentas', '' as 'ctaIngresoVentas',
'21' as 'iva', 'P' as 'tipoItem' , unit.Description, '' as 'comentarioFactura'
from Products pro
left join UnitMeasures unit on unit.Id = pro.UnitMeasureId
left join Prices pri on pro.Id = pri.ProductId





--CAMPOS ALTA PROVEEDOR
SELECT p.BusinessName, p.BusinessName, p.Address, cit.Name, p.PostalCode,
sta.Name, cou.Denomination, p.DocumentNumber, p.Id, p.IsActive, p.IVAConditionId
FROM Providers p
left join Cities cit on cit.Id = p.CityId
left join States sta on sta.Id = p.StateId
left join Countries cou on cou.Id = p.CountryId
where BusinessName is not null and DocumentNumber is not null

select Cost from Products
order by Cost desc