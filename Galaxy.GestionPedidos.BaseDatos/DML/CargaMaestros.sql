/*
Plantilla de script posterior a la implementación							
--------------------------------------------------------------------------------------
 Este archivo contiene instrucciones de SQL que se anexarán al script de compilación.		
 Use la sintaxis de SQLCMD para incluir un archivo en el script posterior a la implementación.			
 Ejemplo:      :r .\miArchivo.sql								
 Use la sintaxis de SQLCMD para hacer referencia a una variable en el script posterior a la implementación.		
 Ejemplo:      :setvar TableName miTabla							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

/*CARGA INICIAL DE MAESTRO*/
--REGISTRO DE RUBROS

DECLARE @ID_RUB INT
INSERT INTO TbMaestro (Codigo, Nombre, Descripcion, TipoMaestro, FechaCreacion, UsuarioCreacion)
VALUES ('MAE_RUBRO','RUBRO','RUBRO DE UNA EMPRESA, ASOCIADO A CLIENTES O PROVEEDORES', 'MAE', GETDATE(), 'Admin')

SET @ID_RUB = (SELECT @@IDENTITY)

INSERT INTO TbMaestroDetalle (Codigo, IdMaestro, Descripcion, Valor, FechaCreacion, UsuarioCreacion)
VALUES
    ('RUB_ABARROTES',@ID_RUB, 'Rubro de Abarrotes', 'ABARROTES', GETDATE() , 'Admin'),
    ('RUB_ALIMENTOS',@ID_RUB, 'Rubro de Alimentos', 'ALIMENTOS', GETDATE() , 'Admin'),
    ('RUB_GIMNASIO',@ID_RUB, 'Rubro de Gimnasios', 'GIMNASIOS', GETDATE() , 'Admin'),
    ('RUB_LIMPIEZA',@ID_RUB, 'Rubro de Limpieza', 'LIMPIEZA', GETDATE() , 'Admin'),
    ('RUB_MEDICINA',@ID_RUB, 'Rubro de Medicamentos', 'MEDICAMENTOS', GETDATE() , 'Admin')

GO

DECLARE @ID_MARCA INT
INSERT INTO TbMaestro (Codigo, Nombre, Descripcion, TipoMaestro, FechaCreacion, UsuarioCreacion)
VALUES ('MAE_MARCA','MARCA','MARCA DE PRODUCTOS', 'MAE', GETDATE(), 'Admin')

SET @ID_MARCA = (SELECT @@IDENTITY)

INSERT INTO TbMaestroDetalle (Codigo, IdMaestro, Descripcion, Valor, FechaCreacion, UsuarioCreacion)
VALUES
    ('MAR_GLORIA',@ID_MARCA, 'Marca Gloria', 'GLORIA', GETDATE() , 'Admin'),
    ('MAR_BOLIVAR',@ID_MARCA, 'Marca Bolivar', 'BOLIVAR', GETDATE() , 'Admin'),
    ('MAR_PRIMOR',@ID_MARCA, 'Marca Primor', 'PRIMOR', GETDATE() , 'Admin'),
    ('MAR_LAIVE',@ID_MARCA, 'Marca Laive', 'LAIVE', GETDATE() , 'Admin'),
    ('MAR_CASERITA',@ID_MARCA, 'Marca Caserita', 'CASERITA', GETDATE() , 'Admin')

GO

DECLARE @ID_CATE INT
INSERT INTO TbMaestro (Codigo, Nombre, Descripcion, TipoMaestro, FechaCreacion, UsuarioCreacion)
VALUES ('MAE_CATEGORIA','CATEGORIA','CATEGORIA DE PRODUCTOS', 'MAE', GETDATE(), 'Admin')

SET @ID_CATE = (SELECT @@IDENTITY)

INSERT INTO TbMaestroDetalle (Codigo, IdMaestro, Descripcion, Valor, FechaCreacion, UsuarioCreacion)
VALUES
    ('CAT_ALIMENTOS',@ID_CATE, 'Categoria Alimentos', 'ALIMENTOS', GETDATE() , 'Admin'),
    ('CAT_LIMPIEZA',@ID_CATE, 'Categoria Limpieza', 'LIMPIEZA', GETDATE() , 'Admin'),
    ('CAT_PERSONAL',@ID_CATE, 'Categoria Uso Personal', 'PERSONAL', GETDATE() , 'Admin'),
    ('CAT_BEBIDAS',@ID_CATE, 'Categoria Bebidas', 'BEBIDAS', GETDATE() , 'Admin'),
    ('CAT_ALCOHOL',@ID_CATE, 'Categoria Bebidas Alcoholicas', 'ALCOHOL', GETDATE() , 'Admin')

GO

DECLARE @ID_ESTADO_PEDIDO INT
INSERT INTO TbMaestro (Codigo, Nombre, Descripcion, TipoMaestro, FechaCreacion, UsuarioCreacion)
VALUES ('MAE_ESTPDD','ESTADO PEDIDO','ESTADOS DEL PEDIDO', 'MAE', GETDATE(), 'Admin')

SET @ID_ESTADO_PEDIDO = (SELECT @@IDENTITY)

INSERT INTO TbMaestroDetalle (Codigo, IdMaestro, Descripcion, Valor, FechaCreacion, UsuarioCreacion)
VALUES
    ('PDD_REGISTRADO',@ID_ESTADO_PEDIDO, 'Pedido registrado', 'REGISTRADO', GETDATE() , 'Admin'),
    ('PDD_RECIBIDO',@ID_ESTADO_PEDIDO, 'Pedido recibido por almacen', 'RECIBIDO', GETDATE() , 'Admin'),
    ('PDD_DESPACHO',@ID_ESTADO_PEDIDO, 'Pedido en proceso de despacho', 'EN DESPACHO', GETDATE() , 'Admin'),
    ('PDD_CAMINO',@ID_ESTADO_PEDIDO, 'Pedido en camino de entrega', 'EN CAMINO', GETDATE() , 'Admin'),
    ('PDD_ENTREGADO',@ID_ESTADO_PEDIDO, 'Pedido entregado', 'ENTREGADO', GETDATE() , 'Admin'),
    ('PDD_CANCELADO',@ID_ESTADO_PEDIDO, 'Pedido cancelado', 'CANCELADO', GETDATE() , 'Admin'),
    ('PDD_RETRASADO',@ID_ESTADO_PEDIDO, 'Pedido retrasado', 'RETRASADO', GETDATE() , 'Admin')

