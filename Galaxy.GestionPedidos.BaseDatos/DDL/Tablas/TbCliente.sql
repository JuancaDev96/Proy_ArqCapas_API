CREATE TABLE [dbo].[TbCliente]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [RazonSocial] VARCHAR(50) NULL, 
    [NombreComercial] VARCHAR(50) NOT NULL, 
    [DocumentoIdentidad] CHAR(12) NOT NULL, 
    [IdMaeTipoDocumento] INT NOT NULL, 
    [Contacto] VARCHAR(50) NOT NULL, 
    [Celular] CHAR(15) NOT NULL, 
    [CorreoElectronico] VARCHAR(100) NULL, 
    [IdMaeRubro] INT NOT NULL, 
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'sql', 
    [FechaModificacion] DATETIME NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL, 
    CONSTRAINT [FK_TbCliente_TbMaestroDetalle_TipoDocumento] FOREIGN KEY ([IdMaeTipoDocumento]) REFERENCES TbMaestroDetalle(Id), 
    CONSTRAINT [FK_TbCliente_TbMaestroDetalle_Rubro] FOREIGN KEY ([IdMaeRubro]) REFERENCES TbMaestroDetalle(Id)
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificador del registro, autoincremental',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Razon social del cliente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'RazonSocial'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre comercial o nombre y apellidos del cliente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'NombreComercial'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Numero de documento de identidad',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'DocumentoIdentidad'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificador del tipo de documento de identidad - Maestro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'IdMaeTipoDocumento'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre de la persona de contacto del cliente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'Contacto'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Numero de celular del cliente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'Celular'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Correo electronico del cliente',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'CorreoElectronico'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificador del Rubro - Maestro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'IdMaeRubro'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'0 - Inactivo / 1 - Activo',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'Estado'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de creación del registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'FechaCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre de usuario del registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de ultima modificacion',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'FechaModificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario de ultima modificacion',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbCliente',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioModificacion'