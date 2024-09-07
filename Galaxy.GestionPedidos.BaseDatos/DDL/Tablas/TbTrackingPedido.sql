CREATE TABLE [dbo].[TbTrackingPedido]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdPedido] INT NULL, 
    [IdMaeEstadoPedido] INT NULL, 
    [Comentario] VARCHAR(200) NULL,
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'sql', 
    [FechaModificacion] DATETIME NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL, 
    CONSTRAINT [FK_TbTrackingPedido_TbPedido] FOREIGN KEY ([IdPedido]) REFERENCES TbPedido(id), 
    CONSTRAINT [FK_TbTrackingPedido_TbMaestroDetalle] FOREIGN KEY ([IdMaeEstadoPedido]) REFERENCES TbMaestroDetalle(id)
)
