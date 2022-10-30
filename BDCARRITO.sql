Create database DBCARRITO

USE DBCARRITO

create table categoria (
IdCategoria int primary key identity,
Descripcion varchar(100),
Activo bit default 1,
FechaRegistro datetime default getdate ()
)

create table marca(
IdMarca int primary key identity,
Descripcion varchar (100),
Activo bit default 1,
FechaRegistro datetime default getdate()
)

create table Producto(
IdProducto int primary key identity,
Nombre varchar(500),
Descripcion varchar(500),
IdMarca int references marca(IdMarca),
IdCategoria int references categoria(IdCategoria),
precio decimal (10,0) default 0,
stock int,
RutaImagen varchar(100),
NombreImagen varchar(100),
Activo bit default 1,
FechaRegistro datetime default getdate()
)


create table cliente (
IdCliente int primary key identity,
Nombre varchar(100),
Apellido varchar(100),
Correo varchar(100),
Clave varchar(100),
Reestablecer bit default 0,
FechaRegistro datetime default getdate()
)

Create table carrito(
 IdCarrito int primary key identity,
IdCliente int references cliente(IdCliente),
IdProducto int references producto(IdProducto),
cantidad int 
)

create table venta(
IdVenta int primary key identity,
IdCliente int references cliente(IdCliente),
TotalProducto int,
MontoTotal decimal(10,2),
Contacto varchar(50),
IdDistrito varchar(10),
Telefono varchar(50),
Direccion varchar(500),
IdTransacion varchar(50),
FechaVenta datetime default getdate()
)

create table detalle_venta(
IdDetalleVenta int primary key identity,
IdVenta int references venta(IdVenta),
IdProducto int references producto(IdProducto),
Cantidad int,
Total decimal(10,2)
)

create table usuario(
IdUsuario int primary key identity,
Nombre varchar(100),
Apellido varchar(100),
Correo varchar(100),
Clave varchar(150),
Reestablecer bit default 1,
Activo bit default 1,
FechaRegistro datetime default getdate()
)

create table Departamento (
IdDepartamento varchar(2) not null ,
Descripcion varchar(45) not null
)

create table provincia (
IdProvincia varchar(4) not null,
Descripcion varchar(45)not null,
IdDepartamento varchar(2) not null
)

Create table distrito(
IdDistrito varchar(6) not null,
Descripcion varchar(45) not null,
IdProvincia Varchar(4) not null,
IdDepartamento varchar(2) not null
)

select * from categoria c 
right join cliente cl
on c.IdCategoria = cl.IdCliente 
right  join usuario u 
on  u.IdUsuario = c.IdCategoria   