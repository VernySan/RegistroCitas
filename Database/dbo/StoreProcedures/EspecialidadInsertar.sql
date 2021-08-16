CREATE PROCEDURE [dbo].[EspecialidadInsertar]
	@Especialidad varchar(50)

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

BEGIN TRY

	IF NOT EXISTS (SELECT * FROM dbo.Especialidad 
					WHERE Especialidad = @Especialidad)

		begin
			INSERT INTO dbo.Especialidad 
			(
			  Especialidad 
			)
			VALUES
			(
			  @Especialidad 
			)

			COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError

		end
		else
		begin
			SELECT 50001 AS CodeError, 'La especialidad ya existe' AS MsgError
			ROLLBACK TRANSACTION TRASA
		end
	END TRY

	BEGIN CATCH
		SELECT 
				ERROR_NUMBER() AS CodeError
			,	ERROR_MESSAGE() AS MsgError

			ROLLBACK TRANSACTION TRASA
	END CATCH

END