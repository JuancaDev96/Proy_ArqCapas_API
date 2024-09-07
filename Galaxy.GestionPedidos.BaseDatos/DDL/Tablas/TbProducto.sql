CREATE TABLE [dbo].[TbProducto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nombre] VARCHAR(50) NULL, 
    [Descripcion] VARCHAR(100) NULL, 
    [IdMaeMarca] INT NULL, 
    [IdMaeCategoria] INT NULL,
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'sql', 
    [FechaModificacion] DATETIME NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL, 
    CONSTRAINT [FK_TbProducto_TbMaestroDetalle_Marca] FOREIGN KEY (IdMaeMarca) REFERENCES TbMaestroDetalle(id), 
    CONSTRAINT [FK_TbProducto_TbMaestroDetalle_Categoria] FOREIGN KEY ([IdMaeCategoria]) REFERENCES TbMaestroDetalle(id)
)
