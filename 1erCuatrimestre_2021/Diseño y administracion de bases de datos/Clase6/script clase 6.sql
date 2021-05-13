-- ----------------------------------------------------------------------------------------
-- UPDATE
-- ----------------------------------------------------------------------------------------

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

-- Modificar la letra de todas las facturas
-- NO EJECUTAR!!!!!!!!!!!!!!!!!!!!!!!!
UPDATE facturas 
SET letra='W';

-- Modificar el monto la factura B-5
UPDATE facturas 
SET monto=355 
WHERE letra='B' AND numero=5;

-- Reviso mi tabla de Facturas
SELECT * FROM facturas;

-- Multiplicar por 2 el monto las facturas del '2018/10/24'
UPDATE facturas 
SET monto=2*monto 
WHERE fecha='2018-10-24';

-- Reviso mi tabla de Facturas
SELECT * FROM facturas;

------------------------------------------------------------------------------------------------------------
--MÁS UPDATE
------------------------------------------------------------------------------------------------------------

-- Creamos la tabla de MejoresClubes
CREATE TABLE MejoresClubes (
	IdClub char(3),
	Nombre varchar(20),
	Pais varchar(20)
)

-- Insertamos varios registros
INSERT INTO MejoresClubes(IdClub,Nombre,Pais) 
VALUES('FCB','FC Barcelona','España'), 
	  ('CAB','CA Boca Juniors','Argentina'),
	  ('MIL','AC Milan','Italia'),
	  ('MUN','FC Bayern München','Alemania'),
	  ('UNI','Manchester United','Inglaterra'),
	  ('FLA','Flamengo','Brasil'),
	  ('TAC','Deportivo Tachira','Venezuela'),
	  ('CHA','CA Chacarita Juniors','Argentina'),
	  ('AJA','AFC Ajax','Holanda'),
	  ('AME','CF AmérYca','Canada')

--Agregamos 2 campos a la tabla
ALTER TABLE dbo.MejoresClubes ADD Fecha datetime NULL
ALTER TABLE dbo.MejoresClubes ADD Descripcion varchar(100) NULL

-- Reviso mi tabla de MejoresClubes
SELECT * FROM MejoresClubes


-- Actualizar todas las fechas de la tabla
UPDATE MejoresClubes 
SET Fecha=GETDATE()

-- Reviso mi tabla de MejoresClubes
SELECT * FROM MejoresClubes


-- Actualizar 2 campos de todos los registros de la tabla
UPDATE MejoresClubes 
SET Fecha=GETDATE(), 
	Descripcion=Nombre + ' de ' + Pais

-- Reviso mi tabla de MejoresClubes
SELECT * FROM MejoresClubes


--***VIA SSMS***
-- Actualizar el Nombre y Pais de 1 club (CF América - Mexico)
--UPDATE MejoresClubes 
--SET Nombre='CF América',
--	Pais='Mexico'
--WHERE IdClub='AME'

-- Actualizar usando la cláusula WHERE
UPDATE MejoresClubes 
SET Fecha=GETDATE(), 
	Descripcion=Nombre + ' de ' + Pais
WHERE IdClub='AME'

-- Reviso mi tabla de MejoresClubes
SELECT * FROM MejoresClubes


-- Especificar un valor calculado
UPDATE MejoresClubes 
SET Fecha=GETDATE()+5
WHERE IdClub='UNI'

-- Reviso mi tabla de MejoresClubes
SELECT * FROM MejoresClubes


--Agregar campo Colores a la tabla
ALTER TABLE MejoresClubes ADD
	Colores varchar(50) NULL DEFAULT 'Sin Definir'

-- Actualizar las filas con valores DEFAULT
UPDATE MejoresClubes 
SET Colores=DEFAULT

-- Actualizar los colores de 1 club
UPDATE MejoresClubes 
SET Colores='Negro, Blanco y Rojo'
WHERE IdClub='CHA'

-- Reviso mi tabla de MejoresClubes
SELECT * FROM MejoresClubes



-- ----------------------------------------------------------------------------------------
-- DELETE
-- ----------------------------------------------------------------------------------------

-- Reviso mi tabla de Facturas
SELECT * FROM facturas;

-- Eliminar todas las facturas
-- NO EJECUTAR!!!!!!!!!!!!!!!!!!!!!!!!
DELETE FROM facturas;

-- Eliminar la factura A-23
DELETE FROM facturas 
WHERE letra='A' AND numero=23;

-- Eliminar la factura A-7
DELETE FROM facturas 
WHERE letra='A' AND numero=7;

-- Reviso mi tabla de Facturas
SELECT * FROM facturas;

-- Eliminar todas las facturas sin consumir los recursos del servidor
-- NO EJECUTAR!!!!!!!!!!!!!!!!!!!!!!!!
TRUNCATE TABLE facturas;


------------------------------------------------------------------------------------------------------------
--MÁS DELETE
------------------------------------------------------------------------------------------------------------

--Creo una tabla grande
SELECT * 
INTO TablaGrande
FROM AdventureWorks2017.Sales.SalesOrderDetail

-- Reviso mi tabla TablaGrande
SELECT * FROM TablaGrande;

--Utilizar DELETE sin la cláusula WHERE
DELETE FROM TablaGrande

-- Reviso mi tabla TablaGrande
SELECT * FROM TablaGrande;


--Creo una tabla grande
DROP TABLE TablaGrande

SELECT * 
INTO TablaGrande
FROM AdventureWorks2017.Sales.SalesOrderDetail

--Consulta la tabla
SELECT * FROM TablaGrande

-- Usar la cláusula WHERE para eliminar un conjunto de filas
DELETE FROM TablaGrande
WHERE SalesOrderID >55000

--Consulta la tabla
SELECT * FROM TablaGrande


------------------------------------------------------------------------------------------------------------
--TRUNCATE
------------------------------------------------------------------------------------------------------------

--Creo una tabla grande
DROP TABLE TablaGrande

SELECT * 
INTO TablaGrande
FROM AdventureWorks2017.Sales.SalesOrderDetail

--Consulta la tabla
SELECT * FROM TablaGrande

--Hago el TRUNCATE
TRUNCATE TABLE TablaGrande

--Consulta la tabla
SELECT * FROM TablaGrande



-- ----------------------------------------------------------------------------------------
-- FUNCIONES DEL SISTEMA
-- ----------------------------------------------------------------------------------------
--STRING FUNCTIONS

-- CONCAT(string1, string2,…)
SELECT CONCAT(letra,'-',numero) AS Fac, monto 
FROM facturas;

-- LEFT(string, number)
SELECT 'Lionel Messi', LEFT('Lionel Messi',3);

-- RIGHT(string, number)
SELECT 'Lionel Messi', RIGHT('Lionel Messi',5);

-- TRIM(string)
SELECT '     Batistuta     ', TRIM('     Batistuta     ');

-- LEN(string)
SELECT 'Claudio Paul Caniggia', LEN('Claudio Paul Caniggia');

-- REPLACE(string, string_pat, string_rep)
SELECT 'DIOS', REPLACE('DIOS','IO','10');

--DATE FUNCTIONS
-- GETDATE()
SELECT *, GETDATE() 
FROM facturas;

-- DATENAME(datepart, date)
SELECT *, DATENAME(weekday,fecha) 
FROM facturas;

-- DATEADD(datepart,number,date)
SELECT *, DATEADD(day,25,fecha) 
FROM facturas;

-- DATEDIFF(datepart,startdate,enddate)
SELECT *, DATEDIFF(day,fecha,GETDATE()) 
FROM facturas;

-- DAY(date) MONTH(date) YEAR(date)
SELECT *, DAY(fecha), MONTH(fecha), YEAR(fecha) 
FROM facturas;



