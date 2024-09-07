CREATE TABLE [dbo].[TbPedidoDetalle]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdPedido] INT NULL, 
    [IdProveedorProducto] INT NULL, 
    [Comentario] VARCHAR(100) NULL, 
    [PrecioUnitario] DECIMAL(10, 2) NULL, 
    [Cantidad] DECIMAL(10, 2) NULL, 
    [TotalBruto] DECIMAL(10, 2) NULL, 
    [TotalNeto] DECIMAL(10, 2) NULL,
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'sql', 
    [FechaModificacion] DATETIME NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL, 
    CONSTRAINT [FK_TbPedidoDetalle_TbPedido] FOREIGN KEY ([IdPedido]) REFERENCES TbPedido(id), 
    CONSTRAINT [FK_TbPedidoDetalle_TbProveedorProducto] FOREIGN KEY ([IdProveedorProducto]) REFERENCES TbProveedorProducto(id)
)
