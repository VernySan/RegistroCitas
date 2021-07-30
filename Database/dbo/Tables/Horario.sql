CREATE TABLE [dbo].[Horario]
(
	[IdHorario] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Inicio] VARCHAR(9) NOT NULL, 
    [Fin] VARCHAR(9) NOT NULL, 
    [Estado] BIT NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_Horario] ON [dbo].[Horario] (Inicio, Fin)
