-- ----------------------------------------------------------------------------------------
-- FUNCIONES DE AGRUPAMIENTO
-- ----------------------------------------------------------------------------------------

-- Cambio a la BD Prueba
USE Prueba

--Eliminamos la tabla facturas
DROP TABLE facturas

-- Creamos la tabla de Facturas
CREATE TABLE facturas(
	letra CHAR(1)	NOT NULL,
	numero INT		NOT NULL,
	fecha DATE,
	monto DECIMAL(16,2),
	PRIMARY KEY (letra,numero)
);

-- Insertamos varios registros
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('A',1,'2018-10-18',500);
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('A',2,'2018-10-19',2500);
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('B',3,'2018-10-19',320);
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('B',4,'2018-10-20',120);
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('B',5,'2018-10-21',560);
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('C',6,'2018-10-22',300);
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('A',7,'2018-10-23',1500);
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('A',8,'2018-10-24',1200);
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('B',9,'2018-10-24',400);
INSERT INTO facturas(letra,numero,fecha,monto) VALUES ('C',10,'2018-10-25',525);


-- Reviso mi tabla de Facturas
SELECT * FROM facturas;


-- COUNT
-- Contar la cantidad de facturas
SELECT COUNT(*) 
FROM facturas;

-- Contar la cantidad de facturas del dia '2018/10/19'
SELECT COUNT(*) 
FROM facturas 
WHERE fecha='2018-10-19';

-- SUM
-- Sumar el total facturado
SELECT SUM(monto) 
FROM facturas;

-- Sumar el total facturado del dia '2018/10/19'
SELECT SUM(monto) 
FROM facturas 
WHERE fecha='2018-10-19';

-- MAX MIN
-- Obtener el maximo y minimo monto de las facturas
SELECT MIN(monto), MAX(monto) 
FROM facturas;

-- Obtener la primera y la ultima fecha facturada
SELECT MIN(fecha), MAX(fecha) 
FROM facturas;

-- AVG
-- Obtener monto promedio facturado
SELECT AVG(monto)
FROM facturas;


-- ----------------------------------------------------------------------------------------
-- MÁS FUNCIONES DE AGRUPAMIENTO
-- ----------------------------------------------------------------------------------------

-- Cambio a la BD AdventureWorks
USE AdventureWorks2017

--Mostrar la tabla Sales.SalesOrderHeader
SELECT * FROM Sales.SalesOrderHeader

--Obtener la cantidad de clientes distintos (CustomerID) que han comprado
SELECT COUNT(DISTINCT CustomerID)
FROM Sales.SalesOrderHeader



--Mostrar la tabla Sales.SalesOrderHeader
SELECT * FROM Sales.SalesOrderHeader

--Obtener el total de las OV (SubTotal) del año 2013 (OrderDate) que no fueron Online (OnlineOrderFlag)
SELECT SUM(SubTotal)
FROM Sales.SalesOrderHeader
WHERE YEAR(OrderDate)=2013 and OnlineOrderFlag=0



--Mostrar la tabla HumanResources.Employee
SELECT * FROM HumanResources.Employee

--Obtener la fecha de nacimiento (BirthDate) del empleado más joven y más viejo que esta casado y sea Assistant
SELECT MAX(BirthDate), MIN(BirthDate)
FROM HumanResources.Employee
WHERE MaritalStatus='M' and JobTitle like '%Assistant%'



--Mostrar la tabla Purchasing.PurchaseOrderDetail
SELECT * FROM Purchasing.PurchaseOrderDetail

--Obtener el promedio de las cantidades (OrderQty) de compras para cantidades mayores a 100 
--y que el producto (ProductID) sea 856, 948, 908, 716, 923, 860 o 871
SELECT AVG(OrderQty)
FROM Purchasing.PurchaseOrderDetail
WHERE OrderQty>100
AND ProductID IN (856, 948, 908, 716, 923, 860, 871)



-- ----------------------------------------------------------------------------------------
-- FUNCIONES DE AGRUPAMIENTO AVANZADO
-- ----------------------------------------------------------------------------------------
-- Cambio a la BD Prueba
USE Prueba

-- GROUP BY 
-- Sumar montos por dia de las facturas
SELECT fecha, SUM(monto) 
FROM facturas 
GROUP BY fecha;

-- Contar la cantidad de faturas por dia
SELECT fecha, COUNT(*) 
FROM facturas 
GROUP BY fecha;

-- HAVING
-- Sumar montos por dia de las facturas pero de los dias que nos fue mal (menos de 1000 pesos)
SELECT fecha, SUM(monto) 
FROM facturas 
GROUP BY fecha 
HAVING SUM(monto)<1000;


-- ----------------------------------------------------------------------------------------
-- MÁS FUNCIONES DE AGRUPAMIENTO AVANZADO
-- ----------------------------------------------------------------------------------------

-- Cambio a la BD AdventureWorks
USE AdventureWorks2017


--Mostrar la tabla Sales.SalesOrderDetail
SELECT * FROM Sales.SalesOrderDetail

--Obtener la suma del monto total por linea (LineTotal) por cada orden de venta (SalesOrderID) 
--ordenado por orden de venta
SELECT SalesOrderID, SUM(LineTotal) AS SubTotal  
FROM Sales.SalesOrderDetail  
GROUP BY SalesOrderID  
ORDER BY SalesOrderID


--Mostrar la tabla Sales.SalesOrderDetail
SELECT * FROM Sales.SalesOrderDetail

--Obtener la suma del monto total por linea (LineTotal) y la canidad de productos vendidos 
--por cada orden de venta (SalesOrderID) 
--ordenado por monto descendente y luego por cantidad de productos descendente
SELECT SalesOrderID, SUM(LineTotal) AS SubTotal, COUNT(ProductID) AS CantProductos 
FROM Sales.SalesOrderDetail 
GROUP BY SalesOrderID  
ORDER BY 2 DESC,3 DESC


--Mostrar la tabla Sales.SalesOrderDetail
SELECT * FROM Sales.SalesOrderDetail

--Obtener la cantidad total de productos vendidos (OrderQty) por cada Producto (ProductId) 
SELECT ProductID, SUM(OrderQty) AS Cant  
FROM Sales.SalesOrderDetail
GROUP BY ProductID


--Mostrar la tabla Sales.SalesOrderHeader
SELECT * FROM Sales.SalesOrderHeader

--Obtener la suma total (SubTotal) de las ordenes de venta por Territorio (TerritoryID), ordenado por Territorio
SELECT TerritoryID, SUM(SubTotal) AS Total
FROM Sales.SalesOrderHeader
GROUP BY TerritoryID
ORDER BY TerritoryID

--Mostrar la tabla Sales.SalesOrderHeader
SELECT * FROM Sales.SalesOrderHeader

--Obtener la suma total (SubTotal), la mas vieja y la más nueva de las ordenes de venta 
--por Territorio (TerritoryID) y Vendedor (SalesPersonID) donde haya atendido un vendedor, 
--ordenado desde el que más vendió al que menos vendió
SELECT TerritoryID, SalesPersonID, SUM(SubTotal) AS Total, MIN(OrderDate) Vieja, MAX(OrderDate) Nueva
FROM Sales.SalesOrderHeader
WHERE SalesPersonID IS NOT NULL
GROUP BY TerritoryID, SalesPersonID
ORDER BY 3 DESC


--Mostrar la tabla Sales.SalesOrderDetail
SELECT * FROM Sales.SalesOrderDetail

--Obtener la suma del monto total por linea (LineTotal) por cada orden de venta (SalesOrderID) 
--de las ordenes menores al id 51131 y que la suma sea mayor a 100.000
--ordenado por la suma total ascendente
SELECT SalesOrderID, SUM(LineTotal) AS SubTotal  
FROM Sales.SalesOrderDetail  
WHERE SalesOrderID<51131
GROUP BY SalesOrderID  
HAVING SUM(LineTotal)>100000
ORDER BY 2


--Mostrar la tabla HumanResources.Employee
SELECT * FROM HumanResources.Employee

--Obtener los primeros 10 cargos (JobTitle) con la cantidad de empleados
--y la fecha de nacimiento (BirthDate) del empleado más viejo
--por cargo de los empleados solteros (MaritalStatus)
--y que el año de la fecha de nacimiento del empleado más viejo sea mayor a 1974
--ordenado por cantidad descendente y fecha de nacimiento ascendente
SELECT TOP 10 JobTitle, COUNT(*) Cant, MIN(BirthDate) Viejo
FROM HumanResources.Employee
WHERE MaritalStatus='S'
GROUP BY JobTitle
HAVING YEAR(MIN(BirthDate))>1974
ORDER BY 2 DESC, 3 ASC


