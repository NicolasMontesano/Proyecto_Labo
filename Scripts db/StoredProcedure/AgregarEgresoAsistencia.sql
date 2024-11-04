create procedure AgregarEgresoAsistencia
@FechaSalida DateTime,
@Id int
as

update Asistencia set FechaSalida = @FechaSalida where IdAsistencia = @Id