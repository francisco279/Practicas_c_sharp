--------CReacion BD----------
Create DATABASE Contactos

use Contactos
---------Creacion Tabla--------------
create table ContactosMAVIFrancisco(
	idContacto int identity (1,1) not null,
	TipoContacto varchar (50) not null,
	Nombre varchar (100) not null,
	Telefono_fijo varchar (10),
	Telefono_movil varchar (10) not null,
	Fecha_nac varchar (50),
	Sexo varchar (10) not null,
	Estado_civil varchar (20)
)
use Contactos
insert into ContactosMAVIFrancisco values ('Amistad', 'Francisco', '6711143091', '6711152436', '2020-09-01', 'Masculino', 'Soltero'),
										('Amistad', 'Jose', '6711143091', '6711152436', '2020-09-01', 'Masculino', 'Soltero'),
										('Amistad', 'Luis', '6711143091', '6711152436', '2020-09-01', 'Masculino', 'Soltero')
use Contactos
select *from ContactosMAVIFrancisco


exec MostrarContactos 'Francisco'

---------------PROCEDIMIENTOS ALMACENADOS---------------

----------Procedimiento para buscar contactos mediante el nombre
create procedure MostrarContactos
@nombre varchar(100)
as
select idContacto, Nombre, Telefono_fijo, Telefono_movil, TipoContacto from ContactosMAVIFrancisco where Nombre=@nombre
go

-----Procedimiento que muestra todos los contactos 
create procedure MostrarTodos
as
select idContacto, Nombre, Telefono_fijo, Telefono_movil, TipoContacto from ContactosMAVIFrancisco
go

--------------Procedimiento para eliminar un contacto 
create procedure EliminarContacto
@id int
as
delete from ContactosMAVIFrancisco where idContacto=@id
go

------------------Procedimiento para insertar uncontacto -----------------

create procedure InsertarContacto 
@tipo varchar(50),
@nombre varchar (50),
@telefonoFijo varchar(20),
@telefonoMovil varchar(20),
@fecha varchar(20),
@sexo varchar(20),
@estadoCivil varchar(20)
as
insert into ContactosMAVIFrancisco values (@tipo, @nombre, @telefonoFijo, @telefonoMovil, @fecha, @sexo, @estadoCivil)
go

----------------Procedimiento para editar contactos---------------------
create procedure EditartarContacto 
@id int,
@tipo varchar(50),
@nombre varchar (50),
@telefonoFijo varchar(20),
@telefonoMovil varchar(20),
@fecha varchar(20),
@sexo varchar(20),
@estadoCivil varchar(20)
as
update ContactosMAVIFrancisco set  TipoContacto=@tipo,Nombre=@nombre, Telefono_fijo=@telefonoFijo, Telefono_movil=@telefonoMovil, Fecha_nac=@fecha, Sexo=@sexo, Estado_civil=@estadoCivil where idContacto=@id
go

exec EditartarContacto 13,'dd','ded','222222','333333', '1900-10-10','Masculino', 'Soltero'


----------------procedimiento mostrar todos los datos
create procedure BuscarTodo
@id int
as
select *from ContactosMAVIFrancisco where idContacto=@id
go

----------------Procedimiento para obtener el id de una persona 
create procedure BuscarId
@nombre varchar(50)
as
select idContacto from ContactosMAVIFrancisco where Nombre=@nombre
go

exec BuscarId Francisco


