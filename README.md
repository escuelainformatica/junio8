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



Procedimiento: (cambiar ALTER a CREATE para crearlo la primera vez)

```sql
USE [Libros]
GO
/****** Object:  StoredProcedure [dbo].[sp_crear_autor]    Script Date: 08/06/2021 11:30:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[sp_crear_autor]
	@nombre varchar(50)
AS
BEGIN
	-- transact-sql
   -- creando un procedimiento nuevo DDL Database Design Language
   -- DDL: create, alter, drop, truncate.

	SET NOCOUNT ON;
	begin transaction;

	-- validar que el autor no existe.
	declare @contador int;
	declare @mensaje varchar(2000);
	-- si no encuentra el valor, @contador va a tener el valor 0
	select @contador =count(*) from autor where nombre=@nombre;  -- SQL

	begin try
		if @contador=0
			begin
			insert into autor(nombre) values(@nombre);
			SELECT cast(@@IDENTITY as int) as IdAutor, '' as Nombre;

			exec InsertarTablaLog 'autor ingresado correctamente ';

			end
		else
			begin
			SELECT -1 as IdAutor, 'autor existe' as Nombre;

			select @mensaje='autor '+@nombre+' ya existe'; -- SQL

			exec InsertarTablaLog @mensaje;
			end
	end try
	begin catch
		select @mensaje='ERROR: '+ ERROR_MESSAGE(); -- SQL
		exec InsertarTablaLog @mensaje;
	end catch
	commit;
END

```

```sql
ALTER PROCEDURE [dbo].[InsertarTablaLog]
	@mensaje varchar(200)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	insert into TablaLog(descripcion) values(@mensaje);


​    
END
```


