CREATE PROCEDURE [dbo].[PacienteObtener]
	@Pasaporte INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
		  p.Pasaporte
	    , p.Cedula
	    , p.Nombre 
	    , p.PrimerApellido
	    , p.SegundoApellido 
	    , p.IdNacionalidad 
		, n.Nacionalidad
		, p.FechaNacimiento
		, DATEDIFF(YEAR,p.FechaNacimiento,GETDATE()) -
		(CASE
			WHEN DATEADD(YY,DATEDIFF(YEAR,p.FechaNacimiento,GETDATE()),p.FechaNacimiento)>GETDATE() THEN
			1
		ELSE
			0 
		END) as Edad
		, p.Telefono
		, p.Enfermedades
		, p.Alergias
		, p.Direccion
		, p.Estado
	FROM 
	  dbo.Paciente p
	  inner join dbo.Nacionalidad n
	    on p.IdNacionalidad = n.IdNacionalidad
	WHERE
	     (@Pasaporte IS NULL OR Pasaporte=@Pasaporte)

END