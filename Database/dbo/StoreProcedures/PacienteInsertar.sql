CREATE PROCEDURE [dbo].[PacienteInsertar]
	@Pasaporte INT,
    @Cedula INT,
	@Nombre varchar(30)	,
	@PrimerApellido varchar(30)	,
	@SegundoApellido varchar(30),
	@IdNacionalidad INT,
	@FechaNacimiento DATE,
	@Telefono INT,
	@Enfermedades varchar(250),
	@Alergias varchar(250),
	@Direccion varchar(250),
	@Estado bit
	
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
	-- AQUI VA EL CODIGO
		
		INSERT INTO dbo.Paciente 
		(
		  Pasaporte
	    , Cedula
	    , Nombre 
	    , PrimerApellido
	    , SegundoApellido 
	    , IdNacionalidad 
		, FechaNacimiento
		, Telefono
		, Enfermedades
		, Alergias
		, Direccion
		, Estado
		)
		VALUES
		(
		  @Pasaporte
		, @Cedula
	    , @Nombre 
	    , @PrimerApellido
	    , @SegundoApellido 
	    , @IdNacionalidad
		, @FechaNacimiento
		, @Telefono
		, @Enfermedades
		, @Alergias
		, @Direccion
		, @Estado
		)


		COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError



	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH


END