CREATE PROCEDURE [dbo].[ServicioListar]
AS BEGIN
	SET NOCOUNT ON

	SELECT
		 IdServicio,
		 Servicio
	FROM dbo.Servicio
	WHERE
	     Estado = 1;
END