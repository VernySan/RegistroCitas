CREATE TABLE [dbo].[Usuario]
(
    [IdUsuario] INT identity (1,1) NOT NULL,
    [Usuario] VARCHAR(30) NOT NULL, 
    [Nombre] VARCHAR(150) NOT NULL, 
    [Contrasena] VARCHAR(30) NOT NULL, 
    [Estado] BIT NOT NULL, 
    CONSTRAINT [PK_Usuario] PRIMARY KEY ([IdUsuario]) 
)
