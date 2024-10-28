CREATE PROCEDURE SP_ALTA_ALUMNO
   
   @Usuario varchar(20),
   @Contrase�a varchar(255),
   @Nombre varchar(50),
   @Apellido varchar(50),
   @DNI varchar(8),
   @FechaNacimiento DATE
   
   As


    INSERT INTO Usuarios (Usuario, Contrase�a, Tipo)
    VALUES (@Usuario, @Contrase�a, 4)

    
    DECLARE @IdUsuario INT
    SET @IdUsuario = SCOPE_IDENTITY()

    
    INSERT INTO Alumnos (Nombre, Apellido, FechaNacimiento, DNI, IdUsuario, Estado)
    VALUES (@Nombre, @Apellido, @FechaNacimiento, @DNI, @IdUsuario, 1)