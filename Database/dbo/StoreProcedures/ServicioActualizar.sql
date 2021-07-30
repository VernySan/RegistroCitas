CREATE PROCEDURE [dbo].[ServicioActualizar]
	@IdServicio INT,
	@Servicio VARCHAR(50),
	@Procedimiento VARCHAR(100),
	@Caracteristicas VARCHAR(250),
	@Precio numeric(18,2),
	@Estado bit
AS BEGIN
SET NOCOUNT ON

	BEGIN TRANSACTION TRASA

	BEGIN TRY
		
	UPDATE dbo.Servicio SET
	 Servicio=@Servicio,
	 Procedimiento=@Procedimiento,
	 Caracteristicas=@Caracteristicas,
	 Precio=@Precio,
	 Estado=@Estado
	WHERE IdServicio=@IdServicio;

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
