CREATE VIEW [dbo].[Vw_Maestros]
	AS
	select 
	m.Codigo as Maestro,
	md.Codigo as Codigo,
	md.id as identificador, 
	valor as ElementoMaestro 
from TbMaestro m
INNER JOIN TbMaestroDetalle md on md.IdMaestro  = m.Id 
where md.Estado = 1 and m.estado = 1 and m.TipoMaestro = 'MAE';
