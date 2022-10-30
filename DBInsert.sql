 select * from usuario

 insert into usuario (Nombre,Apellido,Correo,Clave) values ('Jonathan','De la Cruz','jonathandelacruzfeliciano19@gmail.com','c13c846f3f350144418a4a7ae018c52c9abbc68ed59915fdbc734e8fd34f88f1')

select * from categoria 

insert into categoria (Descripcion) values
('Tecnologia'),
('Muebles'),
('Dormitorio'),
('Casa'),
('Vehiculo')
---update  categoria set Descripcion= 'Gorito del farol'  where IdCategoria= 05

select * from marca
insert into marca(Descripcion) values 
('SONY'),
('TOSHIBA'),
('SANSUMG'),

--update  marca set Descripcion= 'Vini'  where IdMarca= 01 
---update marca set Descripcion= 'AA' where IdMarca=05

select * from departamento

insert into departamento(IdDepartamento,Descripcion) values
('00','San pedro de Macoris'),
('01','Santiago de los Caballeros'),
('02','Romana'),
('03','Santo Domingo')
 --delete  from  departamento where IdDepartamento  >=01
 
select * from provincia

insert into provincia(IdProvincia,Descripcion,IdDepartamento) values
--- provincias
('0101','San pedro de Macoris','01'),
('0102','Santiago de los Caballeros','01'),

--Provincias 
('0201','Romana','02'),
('0202','Santo Domingo','02'),
--provincias 
('0201','Maimon','03'),
('0202','La vega','03')

select * from distrito

insert into distrito (IdDistrito, Descripcion, IdProvincia,IdDepartamento) values 
('010101','Vimenpap','0101','01'),
('010102','BMCargo','0101','01'),

('010201','MBox','0102','01'),
('010202','Vimenpap','0102','01')

