CREATE TABLE [dbo].[alumnos]
(
	[Idalumno] INT NOT NULL PRIMARY KEY IDENTITY, 
    [codigo] CHAR(10) NOT NULL, 
    [nombre] CHAR(75) NOT NULL, 
    [direccion] CHAR(150) NOT NULL, 
    [telefono] CHAR(10) NULL, 
    [dui] CHAR(10) NULL
)
