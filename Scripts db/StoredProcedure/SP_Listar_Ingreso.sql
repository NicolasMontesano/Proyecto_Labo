create procedure spListarIngreso

	@fecha  Date,
	@filtro varchar(255) ,
	@horaDesde int,
	@horaHasta int,
	@minutoDesde int,
 	@minutoHasta int

As

select asist.IdAsistencia,asist.IdAlumno,al.Nombre,al.Apellido,al.DNI,asist.IdEmpleado,asist.FechaEntrada,asist.FechaSalida 
from Asistencia asist 
inner join Alumnos al on al.IdAlumno = asist.IdAlumno
where 
Day(FechaEntrada) = Day(@fecha) 
and Month(FechaEntrada) = Month(@fecha) 
and Year(FechaEntrada) = Year(@fecha)
and Datepart(Hour,FechaEntrada) >= @horaDesde
and Datepart(Hour,FechaEntrada) <= @horaHasta
and Datepart(Minute,FechaEntrada) >= @minutoDesde
and Datepart(Minute,FechaEntrada) <= @minutoHasta

and(@filtro = '' or --hago esto porque el filtro puede venir con datos o vacío, si viene vacío la condición no cambia nada, sino, filtra por nombre, apellido o dni
	al.Nombre = @filtro or 
    al.Apellido = @filtro or 
    al.DNI = @filtro)



