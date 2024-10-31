create procedure AgregarAsistencia
@IdAlumno int,
@IdEmpleado int,
@FechaEntrada DateTime,
@FechaSalida DateTime
AS

	insert into Asistencia (IdAlumno,IdEmpleado,FechaEntrada,FechaSalida) 
		values(@IdAlumno,@IdEmpleado,@FechaEntrada,@FechaSalida)