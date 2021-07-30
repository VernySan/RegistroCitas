CREATE TABLE [dbo].[Cita]
(
	[IdCita] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [Fecha] DATE NOT NULL, 
    [idHorario] INT NOT NULL, 
    [idDoctor] INT NOT NULL, 
    [idPaciente] INT NOT NULL, 
    [idServicio] INT NOT NULL, 
    CONSTRAINT [FK_Cita_Horario] FOREIGN KEY ([IdHorario]) REFERENCES [Horario]([IdHorario]), 
    CONSTRAINT [FK_Cita_Doctor] FOREIGN KEY ([IdDoctor]) REFERENCES [Doctor]([Cedula]), 
    CONSTRAINT [FK_Cita_Paciente] FOREIGN KEY ([IdPaciente]) REFERENCES [Paciente]([Pasaporte]), 
    CONSTRAINT [FK_Cita_Servicio] FOREIGN KEY ([IdServicio]) REFERENCES [Servicio]([IdServicio]) 
)
