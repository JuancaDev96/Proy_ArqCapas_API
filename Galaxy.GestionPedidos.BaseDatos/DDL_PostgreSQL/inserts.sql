insert into puesto (nombre, descripcion)
values 
	('Vendedor', 'Agente de ventas'),
	('Administrador', 'Administrador de ventas'),
	('Repartidor', 'Agente de reparto'),
	('Almacenero', 'Agente de almacen'),
	('Chofer', 'Conductor de unidad repartidora');



insert into Colaborador (nombre, apellidos, CorreoElectronico, idpuesto)
values 
	('Miguel','Gonzales','miguelg@distribuidora.com', 1),
	('Tomas','Garcia','tomasg@distribuidora.com', 3),
	('Manuel','Torres','manuelt@distribuidora.com', 5),
	('Maria','Socorro','marias@distribuidora.com', 4);


	
insert into ColaboradorUsuario (IdColaborador, usuario, clave)
values
	(1, 'mgonzales','123456'),
	(2, 'tgarcia','123456'),
	(3, 'mtorres','123456'),
	(4, 'msocorro','123456');
	

insert into permiso(nombre, descripcion)
values
	('Pedidos', 'Modulo de ventas'),
	('Almacen', 'Modulo de almacen'),
	('tracking', 'Modulo de tracking'),
	('clientes', 'Modulo de clientes'),
	('productos', 'Modulo de productos'),
	('proveedores', 'Modulo de proveedores');
	


insert into ColaboradorUsuarioPermiso (IdColaboradorUsuario, IdPermiso)
values
	(1, 1),
	(1, 4),
	(1, 5),
	(1, 6),
	(1, 3),
	(4, 1),
	(4, 2),
	(4, 3),
	(4, 3),
	(2, 3),
	(2, 1);
