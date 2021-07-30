CREATE PROCEDURE [dbo].[DoctorActualizar]
    @Cedula INT,
	@Nombre varchar(30)	,
	@PrimerApellido varchar(30)	,
	@SegundoApellido varchar(30),
	@IdEspecialidad INT,
	@Telefono INT,
	@Direccion varchar(250),
	@Estado bit

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
	UPDATE dbo.Doctor SET
	 Nombre=@Nombre,
	 PrimerApellido=@PrimerApellido,
	 SegundoApellido=@SegundoApellido,
	 IdEspecialidad=@IdEspecialidad,
	 Telefono=@Telefono,
	 Direccion=@Direccion,
	 Estado=@Estado
	WHERE Cedula=@Cedula

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
