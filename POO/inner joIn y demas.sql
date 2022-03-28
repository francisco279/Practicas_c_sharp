create database PRACTICA_TABLAS

-------------------TABLAS-------------------
USE PRACTICA_TABLAS
create table CATEGORIAS(
IDCATEG INT IDENTITY(1,1) PRIMARY KEY,
CATEGORIA NVARCHAR(100)
)

CREATE TABLE MARCAS(
IDMARCA INT IDENTITY(1,1) PRIMARY KEY,
MARCA NVARCHAR(100)
)

CREATE TABLE PRODUCTOS(
IDPROD INT IDENTITY(1,1) PRIMARY KEY,
IDCATEGORIA INT,
IDMARCA INT,
DESCRIPCION NVARCHAR(100),
PRECIO FLOAT

----------------RELACIONES--------------------
CONSTRAINT RELACION_A_CATEGORIAS FOREIGN KEY (IDCATEGORIA) REFERENCES CATEGORIAS (IDCATEG),
CONSTRAINT RELACION_A_MARCAS FOREIGN KEY (IDMARCA) REFERENCES MARCAS (IDMARCA)
)

insert into CATEGORIAS values 
(''),
('Laptop'),
('Desktop'),
('Impresora'),
('Monitor'),
('Teclado'),
('Tarjeta'),
('Altavoz')

insert into MARCAS values 
(''),
('HP'),
('LG'),
('Samsung'),
('Logitech'),
('Lenovo'),
('Asus'),
('Dell'),
('MSI'),
('Gygabyte'),
('Epson'),
('Nvidia')

-------------PROCEDIMIENTOS ALMACENADOS--------------
-----LISTAR CATEGORIAS
create procedure ListarCategorias 
as
select *from CATEGORIAS order by CATEGORIA asc
go

-----------listar marcas-----------
create proc ListarMarcas
as
select *from MARCAS order by MARCA asc
go

-----AGREGAR PRODUCTO---(en tabla producto)
create procedure AgregarProducto
@idcategoria int,
@idmarca int,
@descrip nvarchar (100),
@prec float
as
insert into PRODUCTOS values (@idcategoria,@idmarca,@descrip,@prec)
go

--------------Listar Productos (INNER JOIN)------------------
select IDPROD AS ID, CATEGORIA, MARCA, DESCRIPCION,PRECIO
FROM PRODUCTOS
INNER JOIN CATEGORIAS ON PRODUCTOS.IDCATEGORIA=CATEGORIAS.IDCATEG
INNER JOIN MARCAS ON PRODUCTOS.IDMARCA=MARCAS.IDMARCA

-------------pROCEDIMIENTO PARA LISTAR PRODUCTOS
-------------CON INNER JOIN
CREATE PROCEDURE ListarProductos
as
select IDPROD AS ID, CATEGORIA, MARCA, DESCRIPCION,PRECIO
FROM PRODUCTOS
INNER JOIN CATEGORIAS ON PRODUCTOS.IDCATEGORIA=CATEGORIAS.IDCATEG
INNER JOIN MARCAS ON PRODUCTOS.IDMARCA=MARCAS.IDMARCA
go


select *From MARCAS
select *From PRODUCTOS

delete from MARCAS where IDMARCA = 2
delete from PRODUCTOS where IDMARCA = 2
insert into PRODUCTOS values (1,12,'dede',22)

---Nota: PARA HACER OPERACIONES EN UN REGISTRO DE UNA TABLA
---PRIMERO VERIFICAR SI TIENE DEPENDENCIAS (LLAVES FORANEAS)