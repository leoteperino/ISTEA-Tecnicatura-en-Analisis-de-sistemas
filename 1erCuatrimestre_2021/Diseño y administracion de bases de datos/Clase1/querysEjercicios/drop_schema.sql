/*Borrar un schema*/
/*Si el schema esta asinado a tablas no se puede dropear
asi que sacamos los schema de las tablas y luego dropeamos*/
alter schema dbo transfer Ventas.Productos;
alter schema dbo transfer Ventas.Productos2;
drop schema Ventas;