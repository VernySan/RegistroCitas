CREATE PROCEDURE [dbo].[CitaActualizar]
	@IdCita INT,
	@Fecha date,
	@IdHorario int,
	@IdDoctor int,
	@IdPaciente int,
	@IdServicio int
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
	UPDATE dbo.Cita SET
	 Fecha=@Fecha,
	 IdHorario=@IdHorario,
	 IdDoctor=@IdDoctor,
	 IdPaciente=@IdPaciente,
	 IdServicio=@IdServicio
	WHERE IdCita=@IdCita

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
