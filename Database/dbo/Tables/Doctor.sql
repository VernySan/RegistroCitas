CREATE TABLE [dbo].[Doctor]
(
	[Cedula] INT NOT NULL PRIMARY KEY, 
    [Nombre] VARCHAR(30) NOT NULL, 
    [PrimerApellido] VARCHAR(30) NOT NULL, 
    [SegundoApellido] VARCHAR(30) NOT NULL, 
    [IdEspecialidad] INT NOT NULL, 
    [Telefono] INT NOT NULL, 
    [Direccion] VARCHAR(250) NOT NULL, 
    [Estado] BIT NOT NULL, 
    CONSTRAINT [FK_Doctor_Especialidad] FOREIGN KEY ([IdEspecialidad]) REFERENCES [Especialidad]([IdEspecialidad]) 
)
