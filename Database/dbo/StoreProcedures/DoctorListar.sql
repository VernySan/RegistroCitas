CREATE PROCEDURE [dbo].[DoctorListar]
AS BEGIN
	SET NOCOUNT ON
		SELECT
	      Cedula
	    , Nombre + ' ' + PrimerApellido + ' ' + SegundoApellido as Doctor
	FROM 
	 dbo.Doctor 
	WHERE
		Estado = 1;
END
