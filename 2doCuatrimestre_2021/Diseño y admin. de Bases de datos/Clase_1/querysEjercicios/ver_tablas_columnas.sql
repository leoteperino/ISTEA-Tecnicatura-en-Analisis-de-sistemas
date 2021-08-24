/*Obtener todas la tablas y columnas de la base Facturacion*/
select so.name, sc.name
from sys.objects so inner join sys.columns sc
on so.object_id = sc.object_id
where so.type = 'u'
order by so.name, sc.name