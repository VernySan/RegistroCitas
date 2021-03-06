CREATE PROCEDURE [dbo].[HorarioActualizar]
	@IdHorario INT,
	@Inicio varchar(9),
	@Fin varchar(9),
	@Estado bit

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
	UPDATE dbo.Horario SET
	 Inicio=@Inicio,
	 Fin=@Fin,
	 Estado=@Estado
	WHERE IdHorario=@IdHorario

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
