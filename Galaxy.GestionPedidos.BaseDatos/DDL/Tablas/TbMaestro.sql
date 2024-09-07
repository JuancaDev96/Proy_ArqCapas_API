CREATE TABLE [dbo].[TbMaestro]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Codigo] CHAR(30) NOT NULL UNIQUE, 
    [Nombre] VARCHAR(50) NOT NULL, 
    [Descripcion] VARCHAR(100) NULL, 
    [TipoMaestro] CHAR(3) NULL,
    [Estado] BIT NOT NULL DEFAULT 1, 
    [FechaCreacion] DATETIME NOT NULL DEFAULT GETDATE(), 
    [UsuarioCreacion] VARCHAR(50) NOT NULL DEFAULT 'sql', 
    [FechaModificacion] DATETIME NULL, 
    [UsuarioModificacion] VARCHAR(50) NULL
)

GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Identificador del registro, autoincremental',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'Id'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Valor constante para acceder al registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'Codigo'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre del maestro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'Nombre'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Descripcion del maestro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'Descripcion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Define el tipo de maestro : MAE = MAESTRO, CFG = CONFIGURACION',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'TipoMaestro'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'0 - Inactivo / 1 - Activo',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'Estado'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de creación del registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'FechaCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Nombre de usuario del registro',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioCreacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Fecha de ultima modificacion',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'FechaModificacion'
GO
EXEC sp_addextendedproperty @name = N'MS_Description',
    @value = N'Usuario de ultima modificacion',
    @level0type = N'SCHEMA',
    @level0name = N'dbo',
    @level1type = N'TABLE',
    @level1name = N'TbMaestro',
    @level2type = N'COLUMN',
    @level2name = N'UsuarioModificacion'