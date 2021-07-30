CREATE PROCEDURE [dbo].[ServicioInsertar]
	@IdServicio INT=NULL,
	@Servicio varchar(50),
	@Procedimiento VARCHAR(100),
	@Caracteristicas VARCHAR(250),
	@Precio numeric(18,2),
	@Estado bit

AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
		INSERT INTO dbo.Servicio 
		(
		 Servicio,
		 Procedimiento,
		 Caracteristicas,
		 Precio,
		 Estado
		)
		VALUES
		(
		 @Servicio,
		 @Procedimiento,
		 @Caracteristicas,
		 @Precio,
		 @Estado
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