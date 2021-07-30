CREATE PROCEDURE [dbo].[PacienteObtener]
	@Pasaporte INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
		  Pasaporte
	    , Cedula
	    , Nombre 
	    , PrimerApellido
	    , SegundoApellido 
	    , IdNacionalidad 
		, FechaNacimiento
		, DATEDIFF(YEAR,FechaNacimiento,GETDATE()) -
		(CASE
			WHEN DATEADD(YY,DATEDIFF(YEAR,FechaNacimiento,GETDATE()),FechaNacimiento)>GETDATE() THEN
			1
		ELSE
			0 
		END) as Edad
		, Telefono
		, Enfermedades
		, Alergias
		, Direccion
		, Estado
	FROM dbo.Paciente
	WHERE
	     (@Pasaporte IS NULL OR Pasaporte=@Pasaporte)

END