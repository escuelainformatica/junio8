# junio8

Ejercicio de Clase


* junio3-2 proyecto servidor web.
* ClienteWebApi ejemplo cliente usando WebApi.


Nota:
> El servidor web IIS Express no permite conexiones externas (fuera del equipo local).
> En el caso de que se necesite trabajar en equipo, es posible usar el siguiente componente:

https://conveyor.cloud/Home/How_To_Install?utm_source=conveyor&utm_medium=extension_install&utm_campaign=conveyor

>Es un componente pagado y gratuito que sirve como proxy para poder compartir IIS express de manera externas
>, ademas de otras ventajas tales como firmas digitales, etc.



Procedimiento:

```sql
ALTER PROCEDURE sp_crear_autor
	@nombre varchar(50)
AS
BEGIN
   -- creando un procedimiento nuevo DDL Database Design Language
   -- DDL: create, alter, drop, truncate.

	SET NOCOUNT ON;
	begin transaction;
	
	insert into autor(nombre) values(@nombre);
	
	commit;
	
	SELECT @@IDENTITY as IdAutor;
	-- return 222;

END
GO
```

