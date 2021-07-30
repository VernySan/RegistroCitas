CREATE TABLE [dbo].[Servicio]
(
	[IdServicio] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Servicio] VARCHAR(50) NOT NULL, 
    [Procedimiento] VARCHAR(100) NOT NULL, 
    [Caracteristicas] VARCHAR(250) NOT NULL, 
    [Precio] NUMERIC(18, 2) NOT NULL, 
    [Estado] INT NOT NULL
)
