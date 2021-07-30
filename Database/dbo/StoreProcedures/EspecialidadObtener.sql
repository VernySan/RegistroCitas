CREATE PROCEDURE [dbo].[EspecialidadObtener]
@IdEspecialidad INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
		Especialidad
	FROM dbo.Especialidad
	WHERE
	     (@IdEspecialidad IS NULL OR IdEspecialidad=@IdEspecialidad)

END