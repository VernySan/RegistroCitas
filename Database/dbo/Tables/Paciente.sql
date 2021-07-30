CREATE TABLE [dbo].[Paciente]
(
	[Pasaporte] INT NOT NULL PRIMARY KEY, 
    [Cedula] INT NOT NULL, 
    [Nombre] VARCHAR(30) NOT NULL, 
    [PrimerApellido] VARCHAR(30) NOT NULL, 
    [SegundoApellido] VARCHAR(30) NOT NULL, 
    [IdNacionalidad] INT NOT NULL, 
    [FechaNacimiento] DATE NOT NULL, 
    [Telefono] INT NOT NULL, 
    [Enfermedades] VARCHAR(250) NOT NULL, 
    [Alergias] VARCHAR(250) NOT NULL, 
    [Direccion] VARCHAR(250) NOT NULL, 
    [Estado] BIT NOT NULL, 
    CONSTRAINT [FK_Paciente_Nacionalidad] FOREIGN KEY ([idNacionalidad]) REFERENCES [Nacionalidad]([idNacionalidad]) 
)
