create procedure sp_Modificar_Alumno_Usuario
@Nombre varchar(50),
@Apellido varchar(50),
@DNI varchar(8),
@Fecha Date,
@Idalumno int,
@idUsuario int,
@Usuario	varchar(20),
@Contraseña varchar(255)
As

update Alumnos set Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI,FechaNacimiento = @Fecha  where IdAlumno = @Idalumno

update Usuarios set Usuario = @Usuario, Contraseña = @Contraseña where Id = @idUsuario