create table Personas_Naturales(
Id integer primary key identity(1,1),
Nombres nvarchar(20),
Apellido_Paterno nvarchar(20),
Apellido_Materno nvarchar(20),
Email nvarchar(50),
CI nvarchar(15),
Activo bit default 0 not null
)

create table Permisos(
Id int primary key identity(1,1),
Descripcion nvarchar(20)
)

create table Personas_con_Accesos(
Id int primary key identity(1,1),
PersonaId int foreign key references Personas_Naturales(Id)
)

create table Usuarios(
Id int primary key identity(1,1),
UserId nvarchar(20),
[Password] nvarchar(100),
PermisoId int foreign key references Permisos(Id),
PersonaId int foreign key references Personas_con_Accesos(Id)
)

create table Tipos_Detalles(
Id int primary key identity(1,1),
Nombre nvarchar(20)
)

create table Clasificacion_Tipos(
Id int primary key identity(1,1),
Nombre nvarchar(20),
DetalleId int foreign key references Tipos_Detalles(Id)
)

create table Alumnos(
Id int primary key identity(1,1),
PersonaId int foreign key references Personas_Naturales(Id)
)

create table Colegios(
Id int primary key identity(1,1),
Nombre nvarchar(30),
Direccion nvarchar(30),
Email nvarchar(50)
)

create table Contactos(
Id int primary key identity(1,1),
PersonaId int foreign key references Personas_con_Accesos(Id)
)

create table Directores(
Id int primary key identity(1,1),
PersonaId int foreign key references Personas_con_Accesos(Id)
)

create table Cursos(
Id int primary key identity(1,1),
Nombre nvarchar(20)
)

create table Turnos(
Id int primary key identity(1,1),
Descripcion nvarchar(20),
Activo bit not null default 0
)

create table Universidades(
Id int primary key identity(1,1),
Descripcion nvarchar(20),
Activo bit not null default 0
)

create table Departamentos(
Id int primary key identity(1,1),
Nombre nvarchar(20)
)

create table Provincias(
Id int primary key identity(1,1),
Nombre nvarchar(20),
DepartamentoId int foreign key references Departamentos(Id)
)

create table Telefonos(
Id int primary key identity(1,1),
Telefono nvarchar(20),
Activo bit not null default 0
)

create table Telefonos_Personas(
Id int primary key identity(1,1),
PersonaId int foreign key references Personas_Naturales(Id),
TelefonoId int foreign key references Telefonos(Id)
)



create table Ciudades(
Id int primary key identity(1,1),
Nombre nvarchar(20),
ProvinciaId int foreign key references Provincias(Id)
)

create table Cursos_Alumnos(
Id int primary key identity(1,1),
AlumnoId int foreign key references Alumnos(Id),
Cursos int foreign key references Cursos(Id)
)

create table Colegios_Ciudades_Turnos(
Id int primary key identity(1,1),
ColegioId int foreign key references Colegios(Id),
CiudadId int foreign key references Ciudades(Id),
TurnoId int foreign key references Turnos(Id)
)

create table Detalle_Alumnos(
Id int primary key identity(1,1),
AlumnoId int foreign key references Alumnos(Id),
ClasificacionId int foreign key references Clasificacion_Tipos(Id)
)

create table Telefonos_Turnos(
Id int primary key identity(1,1),
TurnoId int foreign key references Turnos(Id),
TelefonoId int foreign key references Telefonos(Id)
)