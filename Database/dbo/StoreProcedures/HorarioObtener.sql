CREATE PROCEDURE [dbo].[HorarioObtener]
	@IdHorario INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
		Inicio,
		Fin,
		Estado
	FROM dbo.Horario
	WHERE
	     (@IdHorario IS NULL OR IdHorario=@IdHorario)

END