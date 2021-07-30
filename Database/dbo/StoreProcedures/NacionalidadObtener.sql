CREATE PROCEDURE [dbo].[NacionalidadObtener]
@IdNacionalidad INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
		IdNacionalidad,
		Nacionalidad
	FROM dbo.Nacionalidad
	WHERE
	     (@IdNacionalidad IS NULL OR IdNacionalidad=@IdNacionalidad)

END