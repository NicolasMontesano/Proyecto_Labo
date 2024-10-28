-- Crear la base de datos
CREATE DATABASE GIMNASIO;
GO

-- Usar la base de datos
USE GIMNASIO;
GO

-- Crear la tabla TipoUsuarios
CREATE TABLE TipoUsuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Descripcion VARCHAR(30) UNIQUE NOT NULL
);
GO
-- Crear la tabla Usuarios
CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Usuario VARCHAR(20) UNIQUE NOT NULL,
    Contraseña VARCHAR(255) NOT NULL, -- Contraseña sin UNIQUE
    Tipo INT NOT NULL REFERENCES TipoUsuarios(Id)
);
GO



-- Crear la tabla Alumnos
CREATE TABLE Alumnos (
    IdAlumno Int NOT NULL PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NULL,
    DNI VARCHAR(8) UNIQUE NOT NULL,
    IdUsuario INT NOT NULL REFERENCES Usuarios(Id),
    --Creditos INT NULL,
    Estado INT NOT NULL
);
GO

-- Crear la tabla Creditos_Alumno
CREATE TABLE Creditos_Alumno ( --saco los creditos de tabla alumnos y, los manejamos por disciplina
    IdAlumno Int NOT NULL REFERENCES Alumnos(IdAlumno),
    IdDisciplina INT NOT NULL REFERENCES Disciplina(IdDisciplina),
    Creditos INT NOT NULL DEFAULT 0,
    PRIMARY KEY (IdAlumno, IdDisciplina)
);
GO

-- Crear la tabla Empleados
CREATE TABLE Empleados (
    IdEmpleado Int NOT NULL PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(50) NOT NULL,
    Apellido VARCHAR(50) NOT NULL,
    FechaNacimiento DATE NULL,
    DNI VARCHAR(8) UNIQUE NOT NULL,
    IdUsuario INT NOT NULL REFERENCES Usuarios(Id),
	Activo int
);
GO

-- Crear la tabla Disciplina
CREATE TABLE Disciplina (
    IdDisciplina INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    Nombre VARCHAR(80) NOT NULL,
    Precio MONEY NOT NULL
);
GO

-- Crear la tabla Disciplina_Alumno
CREATE TABLE Disciplina_Alumno (
    IdAlumno Int NOT NULL REFERENCES Alumnos(IdAlumno),
    IdDisciplina INT NOT NULL REFERENCES Disciplina(IdDisciplina),
    Estado INT NOT NULL,
    PRIMARY KEY (IdAlumno, IdDisciplina)
);
GO

-- Crear la tabla Facturas
CREATE TABLE Facturas (
    IdFactura Int NOT NULL PRIMARY KEY,
    IdAlumno Int NOT NULL REFERENCES Alumnos(IdAlumno),
    Monto MONEY NOT NULL,
    FechaDeEmision DATE NOT NULL,
    FechaDePago DATE NULL,
    FechaDeVencimiento DATE NOT NULL
);
GO

-- Crear la tabla Asistencia
CREATE TABLE Asistencia (
    IdAsistencia Int NOT NULL PRIMARY KEY,
    IdAlumno Int NOT NULL REFERENCES Alumnos(IdAlumno),
    IdEmpleado Int NOT NULL REFERENCES Empleados(IdEmpleado),
    FechaEntrada DATETIME NOT NULL,
    FechaSalida DATETIME NOT NULL
);
GO

-- Crear la tabla DisciplinaxAsistencia
CREATE TABLE DisciplinaxAsistencia (
    IdAsistencia Int  NOT NULL REFERENCES Asistencia(IdAsistencia),
    IdDisciplina INT NOT NULL REFERENCES Disciplina(IdDisciplina),
    IdProfesor Int  NOT NULL REFERENCES Empleados(IdEmpleado), -- Cambiar a Profesores si se define tabla de Profesores
    PRIMARY KEY (IdAsistencia, IdDisciplina, IdProfesor)
);
GO

-- Crear la tabla PlanDeEntrenamiento
CREATE TABLE PlanDeEntrenamiento (
    IdRutina INT NOT NULL PRIMARY KEY IDENTITY (1,1),
    Duracion TIME NULL,
    IdAlumno Int  NOT NULL REFERENCES Alumnos(IdAlumno),
    IdProfesor Int  NOT NULL REFERENCES Empleados(IdEmpleado), -- Cambiar a Profesores si se define tabla de Profesores
    Fecha DATE NULL
);
GO

-- Crear la tabla TipoEjercicio
CREATE TABLE TipoEjercicio (
    IdTipo SMALLINT NOT NULL PRIMARY KEY,
    Descripcion VARCHAR(150) NOT NULL
);
GO

-- Crear la tabla Ejercicios
CREATE TABLE Ejercicios (
    IdEjercicio Int  NOT NULL PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL,
    IdTipo SMALLINT NOT NULL REFERENCES TipoEjercicio(IdTipo)
);
GO

-- Crear la tabla RutinaEjercicios
CREATE TABLE RutinaEjercicios (
    IdRutina INT NOT NULL REFERENCES PlanDeEntrenamiento(IdRutina),
    IdEjercicio Int  NOT NULL REFERENCES Ejercicios(IdEjercicio),
    Peso INT NULL,
    Repeticiones INT NULL,
    Duracion TIME NULL,
    PRIMARY KEY (IdRutina, IdEjercicio)
);
GO
insert into TipoUsuarios (Descripcion) values('Administrador'),('Profesor'),('Recepcionista'),('Alumno')
insert into Usuarios(Usuario,Contraseña,Tipo) values('admin','admin',1)
insert into Usuarios (Usuario,Contraseña,Tipo) values('NicoPrueba','Prueba',4)
insert into Usuarios (Usuario,Contraseña,Tipo) values('Agus','test',2)

SELECT * FROM Usuarios;

select *from TipoUsuarios
select *from Empleados

insert into Empleados (Nombre,Apellido,DNI,IdUsuario,Activo) values('Administrador','Administrador','00000000',1,1)
