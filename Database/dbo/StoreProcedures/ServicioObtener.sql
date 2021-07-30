﻿CREATE PROCEDURE [dbo].[ServicioObtener]
	@IdServicio INT=NULL


AS BEGIN
	SET NOCOUNT ON

	SELECT
		 Servicio,
		 Procedimiento,
		 Caracteristicas,
		 Precio,
		 Estado
	FROM dbo.Servicio
	WHERE
	     (@IdServicio IS NULL OR IdServicio=@IdServicio)

END