CREATE PROCEDURE [dbo].[SpInsertarProducto]
	@Nombre VARCHAR(50),
	@Descripcion VARCHAR(150),
	@IdMaeMarca INT,
	@IdMaeCategoria INT,
	@FechaCreacion DATETIME,
	@UsuarioRegistro VARCHAR(50)
AS
BEGIN
	
	INSERT INTO TbProducto (Nombre, Descripcion, IdMaeMarca, IdMaeCategoria, FechaCreacion, UsuarioCreacion)
	VALUES (@Nombre, @Descripcion, @IdMaeMarca, @IdMaeCategoria, @FechaCreacion, @UsuarioRegistro)

END