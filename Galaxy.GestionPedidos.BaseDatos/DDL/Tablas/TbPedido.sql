CREATE TABLE [dbo].[TbPedido]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdCliente] INT NULL, 
    [IdColaborador] INT NULL, 
    [TotalBruto] DECIMAL(10, 2) NULL, 
    [TotalNeto] DECIMAL(10, 2) NULL, 
    [AdelantoPedido] DECIMAL(10, 2) NULL,
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'sql', 
    [FechaModificacion] DATETIME NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL, 
    CONSTRAINT [FK_TbPedido_TbCliente] FOREIGN KEY ([IdCliente]) REFERENCES TbCliente(Id)
)
