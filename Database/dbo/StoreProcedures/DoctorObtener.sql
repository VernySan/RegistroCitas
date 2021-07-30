CREATE PROCEDURE [dbo].[DoctorObtener]
	@Cedula INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
	      Cedula
	    , Nombre 
	    , PrimerApellido
	    , SegundoApellido 
	    , IdEspecialidad 
		, Telefono
		, Direccion
		, Estado
	FROM dbo.Doctor
	WHERE
	     (@Cedula IS NULL OR Cedula=@Cedula)

END