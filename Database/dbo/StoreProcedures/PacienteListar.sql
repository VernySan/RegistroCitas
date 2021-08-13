CREATE PROCEDURE [dbo].[PacienteListar]
AS BEGIN
	SET NOCOUNT ON

	SELECT
		  Pasaporte 
	    , Nombre + ' ' + PrimerApellido + ' ' + SegundoApellido Paciente
	FROM 
	  dbo.Paciente 
	WHERE
	     Estado = 1;

END