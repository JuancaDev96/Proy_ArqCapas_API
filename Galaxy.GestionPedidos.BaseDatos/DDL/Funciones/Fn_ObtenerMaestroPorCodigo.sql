CREATE FUNCTION [dbo].[Fn_ObtenerMaestroPorCodigo]
(
	@maestro char(30)
)
RETURNS @returntable TABLE
(
	Codigo char(30),
	Identificador int,
	Valor varchar(100)
)
AS
BEGIN
	INSERT @returntable
	select 
		md.Codigo as Codigo,
		md.id as identificador, 
		valor as ElementoMaestro 
	from TbMaestro m
		INNER JOIN TbMaestroDetalle md on md.IdMaestro  = m.Id 
	where 
		md.Estado = 1 and 
		m.estado = 1 and 
		m.TipoMaestro = 'MAE' and
		m.Codigo = @maestro
	RETURN
END
