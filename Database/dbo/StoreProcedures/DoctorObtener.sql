CREATE PROCEDURE [dbo].[DoctorObtener]
	@Cedula INT=NULL

AS BEGIN
	SET NOCOUNT ON

	SELECT
	      a.Cedula
	    , a.Nombre 
	    , a.PrimerApellido
	    , a.SegundoApellido 
	    , a.IdEspecialidad 
		, b.Especialidad
		, a.Telefono
		, a.Direccion
		, a.Estado
	FROM 
	 dbo.Doctor a
	   inner join
	 dbo.Especialidad b
	   on a.IdEspecialidad = b.IdEspecialidad 
	WHERE
	     (@Cedula IS NULL OR Cedula=@Cedula)

END