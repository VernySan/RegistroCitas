CREATE PROCEDURE [dbo].[NacionalidadActualizar]
	@IdNacionalidad INT,
	@Nacionalidad VARCHAR(15)
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
	UPDATE dbo.Nacionalidad SET
	 Nacionalidad=@Nacionalidad
	WHERE IdNacionalidad=@IdNacionalidad

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
