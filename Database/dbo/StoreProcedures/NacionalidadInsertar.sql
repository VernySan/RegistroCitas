CREATE PROCEDURE [dbo].[NacionalidadInsertar]
	@Nacionalidad varchar(50)

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

BEGIN TRY

	IF NOT EXISTS (SELECT * FROM dbo.Nacionalidad 
					WHERE Nacionalidad = @Nacionalidad)

		begin
			INSERT INTO dbo.Nacionalidad 
			(
			  Nacionalidad 
			)
			VALUES
			(
			  @Nacionalidad 
			)

			COMMIT TRANSACTION TRASA
		
		SELECT 0 AS CodeError, '' AS MsgError

		end
		else
		begin
			SELECT 50001 AS CodeError, 'La Nacionalidad ya existe' AS MsgError
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