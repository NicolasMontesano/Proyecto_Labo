create procedure sp_Modificar_Empleado_Usuario
@Nombre varchar(50),
@Apellido varchar(50),
@DNI varchar(8),
@Fecha Date,
@IdEmpleado int,
@idUsuario int,
@Usuario	varchar(20),
@Contrase�a varchar(255)
As

update Empleados set Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI,FechaNacimiento = @Fecha  where IdEmpleado = @IdEmpleado

update Usuarios set Usuario = @Usuario, Contrase�a = @Contrase�a where Id = @idUsuario