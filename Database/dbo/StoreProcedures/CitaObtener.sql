CREATE PROCEDURE [dbo].[CitaObtener]
	@IdCita INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
		Fecha,
		IdHorario,
		IdDoctor,
		IdPaciente,
		IdServicio
	FROM dbo.Cita
	WHERE
	     (@IdCita IS NULL OR IdCita=@IdCita)

END