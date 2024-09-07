CREATE TABLE [dbo].[TbProveedor]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[RazonSocial] VARCHAR(50) NULL, 
    [NombreComercial] VARCHAR(50) NOT NULL, 
    [DocumentoIdentidad] CHAR(12) NOT NULL, 
    [IdMaeTipoDocumento] INT NOT NULL, 
    [Celular] CHAR(9) NOT NULL, 
    [CorreoElectronico] VARCHAR(100) NULL, 
    [IdMaeRubro] INT NOT NULL, 
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'sql', 
    [FechaModificacion] DATETIME NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL, 
    CONSTRAINT [FK_Proveedor_TbMaestroDetalle_Rubro] FOREIGN KEY ([IdMaeRubro]) REFERENCES TbMaestroDetalle(Id)
)
