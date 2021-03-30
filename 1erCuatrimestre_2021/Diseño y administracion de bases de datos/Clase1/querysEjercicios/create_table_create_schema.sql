/*Crear una tabla - punto de los ejercicios*/
create table Productos(
	codigo int,
	nombre varchar(30)
); 

/*Colocar la tabla creada dentro del esquema Ventas*/
alter schema Ventas transfer dbo.Productos;

/*Tambien podemos crear directamente una tabla y 
colocarle el esquema en su creacion*/
create table Ventas.Productos2(
	codigo int,
	nombre varchar(30)
);
