CREATE PROCEDURE [dbo].[HorarioListar]
AS BEGIN
	SET NOCOUNT ON
	SELECT
		IdHorario,
		Inicio + ' a ' + Fin as Horario
	FROM dbo.Horario
	WHERE
	     Estado = 1;
END