CREATE TABLE [dbo].[TbProveedorProducto]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdProveedor] INT NULL, 
    [IdProducto] INT NULL, 
    [PrecioBruto] DECIMAL(10, 2) NULL, 
    [PrecioNeto] DECIMAL(10, 2) NULL, 
    [Stock] DECIMAL(10, 2) NULL,
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'sql', 
    [FechaModificacion] DATETIME NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL, 
    CONSTRAINT [FK_TbProveedorProducto_TbProveedor] FOREIGN KEY ([IdProveedor]) REFERENCES TbProveedor(id), 
    CONSTRAINT [FK_TbProveedorProducto_TbProducto] FOREIGN KEY ([IdProducto]) REFERENCES TbProducto(Id)
)
