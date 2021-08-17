-- ----------------------------------------------------------------------------------------
-- CARGA INICIAL DE DATOS
-- ----------------------------------------------------------------------------------------

DROP TABLE IF EXISTS clientes;

CREATE TABLE clientes (
	codigo int IDENTITY(1,1),
	nombre varchar(20) not null,
	apellido varchar(20) not null,
	cuit varchar(13),
	direccion varchar(50),
	edad tinyint,
	PRIMARY KEY (codigo)
);

INSERT INTO clientes (nombre,apellido,cuit,direccion,edad)
VALUES ('Lionel','Messi','xxxxx','Peru 323',32),
	   ('Carlos','Tevez','xxxxx','Chile 320',36),
	   ('Diego','Maradona','xxxxx','Venezuela 567',59),
	   ('Juan','Riquelme','xxxxx','Uruguay 680',41),
	   ('Gabriel','Batistuta','xxxxx','Colombia 1211',51),
	   ('Mario','Kempes','xxxxx','Chile 111',65),
	   ('Javier','Masherano','xxxxx','Brasil 954',35),
	   ('Oscar','Ruggeri','xxxxx','Canada 2322',58),
	   ('Javier','Zanetti','xxxxx','Mexico 1986',46),
	   ('Diego','Simeone','xxxxx','Costa Rica 1345',49),
	   ('Juan','Veron','xxxxx','Estados Unidos 1223',44),
	   ('Pablo','Aimar','xxxxx',NULL,40),
	   ('Claudio','Caniggia','xxxxx','',53);


-- ----------------------------------------------------------------------------------------
-- SELECT
-- ----------------------------------------------------------------------------------------

-- Select de toda la tabla
SELECT * 
FROM clientes;

-- Seleccionar solo nombre
SELECT nombre 
FROM clientes;

-- Seleccionar solo nombre y apellido
SELECT nombre,apellido 
FROM clientes;

-- Saludar a todos los clientes (operaciones en los campos + alias)
SELECT 'Hola', nombre,apellido 
FROM clientes;

SELECT 'Hola', CONCAT(nombre,' ',apellido) 
FROM clientes;

SELECT CONCAT('Hola ',nombre,' ',apellido) AS Saludo 
FROM clientes;

-- Seleccionar solo nombre y apellido de los clientes con nombre Javier
SELECT nombre,apellido 
FROM clientes 
WHERE nombre='Javier';

-- Seleccionar todos los datos de los clientes con codigo igual 5
SELECT * 
FROM clientes 
WHERE codigo=5;

-- Seleccionar todos los datos de los clientes con codigo mayor a 5
SELECT * 
FROM clientes 
WHERE codigo>5;


-- ----------------------------------------------------------------------------------------
-- SELECT con operadores logicos y de comparacion
-- ----------------------------------------------------------------------------------------

-- Seleccionar todos los datos de los clientes con codigo mayor a 5 y menor o igual a 10
SELECT * 
FROM clientes 
WHERE codigo>5 AND codigo<=10;

-- Seleccionar todos los datos de los clientes con codigo igual a 2 o nombre Oscar
SELECT * 
FROM clientes 
WHERE codigo=2 OR nombre='Oscar';

-- Seleccionar todos los datos de los clientes con codigo menor a 5 y nombre Lionel o Juan
-- Ojo con el uso de los parentesis
SELECT * 
FROM clientes 
WHERE codigo<5 AND (nombre='Lionel' OR nombre='Juan');

-- Mismo query anterior, moviendo los parentesis
SELECT * 
FROM clientes 
WHERE (codigo<5 AND nombre='Lionel') OR nombre='Juan';

-- Todos los clientes con Direccion vacia
SELECT * 
FROM clientes 
WHERE direccion IS NULL;

-- Todos los clientes con Direccion como cadena vacia
SELECT * 
FROM clientes 
WHERE direccion='';

-- Todos los clientes que tengan Direccion 
SELECT * 
FROM clientes 
WHERE direccion IS NOT NULL;


-- ----------------------------------------------------------------------------------------
-- BETWEEN
-- ----------------------------------------------------------------------------------------

-- Todos los clientes con codigo entre 4 y 9
SELECT * 
FROM clientes 
WHERE codigo BETWEEN 4 AND 9;

-- Todos los clientes con codigo que NO esten entre 4 y 9
SELECT * 
FROM clientes 
WHERE codigo NOT BETWEEN 4 AND 9;

-- ----------------------------------------------------------------------------------------
-- IN
-- ----------------------------------------------------------------------------------------

-- Todos los clientes con apellidos Kempes, Batistuta, Zanetti y Arango
SELECT * 
FROM clientes 
WHERE apellido IN ('Kempes','Batistuta','Zanetti','Arango');

-- Todos los clientes con codigo que NO sean de apellido Masherano o Aimar
SELECT * 
FROM clientes 
WHERE apellido NOT IN ('Masherano','Aimar');


-- ----------------------------------------------------------------------------------------
-- LIKE
-- ----------------------------------------------------------------------------------------

-- Todos los clientes con Direccion que contenga "vene"
SELECT * 
FROM clientes 
WHERE direccion LIKE '%vene%';

-- Todos los clientes cuya apellido termine en "a"
SELECT * 
FROM clientes 
WHERE apellido LIKE '%a';

-- Todos los clientes cuya 2da letra del apellido sea una "e"
SELECT * 
FROM clientes 
WHERE apellido LIKE '_e%';

-- ----------------------------------------------------------------------------------------
-- ORDER BY
-- ----------------------------------------------------------------------------------------

-- Todos los clientes ordenados por nombre ascendente
SELECT * 
FROM clientes 
ORDER BY nombre;

-- Todos los clientes desde el más viejo al más joven
SELECT * 
FROM clientes 
ORDER BY edad DESC;

-- Todos los clientes ordenados por nombre ascendente y apellido descendente
SELECT * 
FROM clientes 
ORDER BY nombre ASC, apellido DESC;

-- ----------------------------------------------------------------------------------------
-- TOP
-- ----------------------------------------------------------------------------------------

-- 5 clientes
SELECT TOP 5 * 
FROM clientes;

-- Últimos 5 clientes
SELECT TOP 5 * 
FROM clientes
ORDER BY codigo DESC;


-- ----------------------------------------------------------------------------------------
-- DISTINCT
-- ----------------------------------------------------------------------------------------

-- Nombres distintos
SELECT DISTINCT nombre
FROM clientes;

SELECT DISTINCT nombre, apellido
FROM clientes;


