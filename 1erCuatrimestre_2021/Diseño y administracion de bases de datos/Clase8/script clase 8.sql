----------------------------------------------------------------------------
--Consultas entre varias tablas
----------------------------------------------------------------------------
--Selecciono la BD Prueba
USE Prueba

-- Genero las tablas Jugador y Club
CREATE TABLE Jugador(
	Nombre Varchar(25),
	IdClub varchar(3)
)

CREATE TABLE Club(
	Id varchar(3),
	NombreClub varchar(25)
)

--Inserto datos de prueba
INSERT INTO Jugador(Nombre,IdClub) VALUES('Carlos Tevez','BOC')
INSERT INTO Jugador(Nombre,IdClub) VALUES('Lionel Messi','FCB')
INSERT INTO Jugador(Nombre,IdClub) VALUES('Luis Suarez','FCB')
INSERT INTO Jugador(Nombre,IdClub) VALUES('Gonzalo Higuain','JUV')
INSERT INTO Jugador(Nombre,IdClub) VALUES('Angel Di Maria','PSG')
INSERT INTO Jugador(Nombre,IdClub) VALUES('Alejandro Manzanares',NULL)

INSERT INTO Club(Id,NombreClub) VALUES('BOC','Boca Juniors')
INSERT INTO Club(Id,NombreClub) VALUES('FCB','FC Barcelona')
INSERT INTO Club(Id,NombreClub) VALUES('JUV','Juventus')
INSERT INTO Club(Id,NombreClub) VALUES('PSG','Paris Saint Germain')
INSERT INTO Club(Id,NombreClub) VALUES('CHA','CA Chacarita Juniors')

-- Muestro el contenido de las tablas
SELECT * from Jugador
SELECT * from Club

-- Producto Cartesiano
Select *
from Jugador, Club

-- Producto Cartesiano (CON ALIAS)
Select *
from Jugador j, Club c

-- Composición Interna (INNER JOIN Implícito)
Select *
from Jugador, Club
WHERE Jugador.IdClub=Club.Id


-- Composición Interna CON ALIAS (INNER JOIN Implícito)
Select *
from Jugador j, Club c
WHERE j.IdClub=c.Id

------------------------------------------------------
-- INNER JOIN
------------------------------------------------------
Select *
from Jugador j
INNER JOIN Club c ON j.IdClub=c.Id

------------------------------------------------------
-- LEFT JOIN
------------------------------------------------------
Select *
from Jugador j
LEFT JOIN Club c ON j.IdClub=c.Id

------------------------------------------------------
-- LEFT JOIN quitando los que hagan match
------------------------------------------------------
Select *
from Jugador j
LEFT JOIN Club c ON j.IdClub=c.Id
WHERE c.Id IS NULL

------------------------------------------------------
-- RIGHT JOIN
------------------------------------------------------
Select *
from Jugador j
RIGHT JOIN Club c ON j.IdClub=c.Id

------------------------------------------------------
-- RIGHT JOIN quitando los que hagan match
------------------------------------------------------
Select *
from Jugador j
RIGHT JOIN Club c ON j.IdClub=c.Id
WHERE j.IdClub IS NULL

------------------------------------------------------
-- FULL JOIN
------------------------------------------------------
Select *
from Jugador j
FULL JOIN Club c ON j.IdClub=c.Id

------------------------------------------------------
-- FULL JOIN quitando los que hagan match 
------------------------------------------------------
Select *
from Jugador j
FULL JOIN Club c ON j.IdClub=c.Id
WHERE j.IdClub IS NULL OR c.Id IS NULL

------------------------------------------------------
-- CROSS JOIN (otro ejemplo de producto cartesiano)
------------------------------------------------------
Select *
from Jugador j 
CROSS JOIN Club c



----------------------------------------------------------------------------
--MÁS Consultas entre varias tablas
----------------------------------------------------------------------------

--Selecciono la BD AdventureWorks
USE AdventureWorks2017


--Muestro las tablas base de mi consulta
SELECT * FROM Person.Person
SELECT * FROM Person.Address
SELECT * FROM Person.BusinessEntityAddress
SELECT * FROM Person.StateProvince
SELECT * FROM Person.CountryRegion

--Obtener el nombre y la dirección completa de las personas
SELECT p.FirstName, p.LastName, a.AddressLine1, a.City, a.StateProvinceID, s.StateProvinceCode, s.Name Provincia,
s.CountryRegionCode, c.Name Pais
FROM Person.Person p
INNER JOIN Person.BusinessEntityAddress pa ON p.BusinessEntityID=pa.BusinessEntityID
INNER JOIN Person.Address a ON pa.AddressID=a.AddressID
INNER JOIN Person.StateProvince s ON a.StateProvinceID=s.StateProvinceID
INNER JOIN Person.CountryRegion c ON s.CountryRegionCode=c.CountryRegionCode

--Obtener el nombre y la dirección completa de las personas. Agregar la información espacial y filtrar solo los de Australia
SELECT p.FirstName, p.LastName, a.AddressLine1, a.City, a.StateProvinceID, s.StateProvinceCode, s.Name Provincia,
s.CountryRegionCode, c.Name Pais, a.SpatialLocation
FROM Person.Person p
INNER JOIN Person.BusinessEntityAddress pa ON p.BusinessEntityID=pa.BusinessEntityID
INNER JOIN Person.Address a ON pa.AddressID=a.AddressID
INNER JOIN Person.StateProvince s ON a.StateProvinceID=s.StateProvinceID
INNER JOIN Person.CountryRegion c ON s.CountryRegionCode=c.CountryRegionCode
WHERE s.CountryRegionCode='AU'



--Muestro las tablas base de mi consulta
SELECT * FROM Person.Person
SELECT * FROM Person.Password
SELECT * FROM Person.PersonPhone
SELECT * FROM Person.PhoneNumberType

--Obtener el nombre, password, telefono y tipo de telefono de las personas
SELECT p.FirstName, p.LastName, pa.PasswordSalt, pf.PhoneNumber, ty.Name TipoTelefono
FROM Person.Person p
INNER JOIN Person.Password pa ON p.BusinessEntityID=pa.BusinessEntityID
INNER JOIN Person.PersonPhone pf ON p.BusinessEntityID=pf.BusinessEntityID
INNER JOIN Person.PhoneNumberType ty ON pf.PhoneNumberTypeID=ty.PhoneNumberTypeID



--Muestro las tablas base de mi consulta
SELECT * FROM Person.Person
SELECT * FROM Sales.PersonCreditCard
SELECT * FROM Sales.CreditCard

--Obtener el nombre, y la info de las tarjetas de crédito de las personas que han comprado
SELECT p.FirstName, p.LastName, cc.CardType, cc.CardNumber, cc.ExpMonth, cc.ExpYear
FROM Person.Person p
INNER JOIN Sales.PersonCreditCard pc ON p.BusinessEntityID=pc.BusinessEntityID
INNER JOIN Sales.CreditCard cc ON pc.CreditCardID=cc.CreditCardID

--Obtener el nombre, y la info de las tarjetas de crédito de las personas que han comprado (y las que no también)
SELECT p.FirstName, p.LastName, cc.CardType, cc.CardNumber, cc.ExpMonth, cc.ExpYear
FROM Person.Person p
LEFT JOIN Sales.PersonCreditCard pc ON p.BusinessEntityID=pc.BusinessEntityID
LEFT JOIN Sales.CreditCard cc ON pc.CreditCardID=cc.CreditCardID

--Obtener el nombre, de las personas que no han comprado con tarjeta de crédito
SELECT p.FirstName, p.LastName, cc.CardType, cc.CardNumber, cc.ExpMonth, cc.ExpYear
FROM Person.Person p
LEFT JOIN Sales.PersonCreditCard pc ON p.BusinessEntityID=pc.BusinessEntityID
LEFT JOIN Sales.CreditCard cc ON pc.CreditCardID=cc.CreditCardID
WHERE pc.BusinessEntityID IS NULL



--Muestro las tablas base de mi consulta
SELECT * FROM Sales.SalesOrderHeader
SELECT * FROM Sales.SalesTerritory
SELECT * FROM Person.CountryRegion

--Obtener la cantidad de ordenes de venta y el total vendido por país ordenado desde el que más vendió al que menos
SELECT c.Name Pais, COUNT(s.SalesOrderNumber) Cant, SUM(s.SubTotal) Total
FROM Sales.SalesOrderHeader s
INNER JOIN Sales.SalesTerritory t ON s.TerritoryID=t.TerritoryID
INNER JOIN Person.CountryRegion c ON t.CountryRegionCode=c.CountryRegionCode
GROUP BY c.Name
ORDER BY 3 DESC



--Muestro las tablas base de mi consulta
SELECT * FROM Sales.SalesOrderHeader
SELECT * FROM Sales.CreditCard

--Obtener la cantidad de ordenes de venta y el total vendido por tarjeta de crédito 
--ordenado desde la que más vendió al que menos
SELECT cc.CardType Tarjeta, COUNT(s.SalesOrderNumber) Cant, SUM(s.SubTotal) Total
FROM Sales.SalesOrderHeader s
INNER JOIN Sales.CreditCard cc ON s.CreditCardID=cc.CreditCardID
GROUP BY cc.CardType
ORDER BY 3 DESC


