create table Prodcutos(
	Id int identity(1,1) primary key,
	Nombre nvarchar(100),
	Descripcion nvarchar (100),
	Marca nvarchar (100),
	Precio float,
	Stock int
)

insert into Prodcutos values	('Gaseosa', '3 litros', 'marcacola', 7.5, 24),
								('Chocolate', '100 gramos', 'Iberica', 12.5, 46),
								('Leche', 'Deslactosada', 'Supervaca', 7.3, 22),
								('Aceite', '1 litro', 'alijugos', 3.5, 64)

select *from Prodcutos

create procedure MostrarProductos
as
select *from Prodcutos
go

create procedure InsertarProductos
@nombre nvarchar(100),
@desc nvarchar(100),
@marca nvarchar(100),
@precio float,
@stock int
as
insert into Prodcutos values (@nombre, @desc, @marca, @precio,@stock)
go

create procedure EditarProductos
@nombre nvarchar(100),
@desc nvarchar(100),
@marca nvarchar(100),
@precio float,
@stock int,
@id int
as
update Prodcutos set Nombre=@nombre, Descripcion=@desc, Marca=@marca, Precio=@precio, Stock=@stock
where Id=@id
go


create procedure EliminarProductos
@idProd int
as
delete from Prodcutos where Id=@idProd
go
exec MostrarProductos