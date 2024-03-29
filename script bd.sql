CREATE TABLE [dbo].[Alumnos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NOT NULL,
 CONSTRAINT [PK__Alumnos__3214EC074484B76B] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[ProvinciaId] [int] NULL,
 CONSTRAINT [PK__Ciudades__3214EC07B80605F0] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clasificacion_Tipos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clasificacion_Tipos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](20) NULL,
	[DetalleId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Colegios]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colegios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[Direccion] [nvarchar](30) NULL,
	[Email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Colegios_Ciudades_Turnos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Colegios_Ciudades_Turnos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ColegioId] [int] NULL,
	[CiudadId] [int] NULL,
	[TurnoId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Contactos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contactos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cursos_Alumnos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos_Alumnos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlumnoId] [int] NULL,
	[Cursos] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Detalle_Alumnos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Alumnos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AlumnoId] [int] NULL,
	[ClasificacionId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Directores]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Directores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permisos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permisos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personas_con_Accesos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas_con_Accesos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personas_Naturales]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas_Naturales](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](20) NULL,
	[Apellido_Paterno] [nvarchar](20) NULL,
	[Apellido_Materno] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[CI] [nvarchar](15) NULL,
	[Activo] [bit] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Provincias]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](20) NULL,
	[DepartamentoId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Telefonos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Telefono] [nvarchar](20) NULL,
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Telefonos_Personas]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos_Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PersonaId] [int] NULL,
	[TelefonoId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Telefonos_Turnos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos_Turnos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TurnoId] [int] NULL,
	[TelefonoId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tipos_Detalles]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_Detalles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Turnos]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turnos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](20) NULL,
	[Activo] [bit] NOT NULL DEFAULT ((0)),
	[DirectorId] [int] NULL,
	[ContactoId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Universidades]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Universidades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](20) NULL,
	[Activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 16/11/2016 02:08:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](20) NULL,
	[Password] [nvarchar](100) NULL,
	[PermisoId] [int] NULL,
	[PersonaId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Ciudades] ON 

INSERT [dbo].[Ciudades] ([Id], [Nombre], [ProvinciaId]) VALUES (4, N'Yacuiba', 5)
SET IDENTITY_INSERT [dbo].[Ciudades] OFF
SET IDENTITY_INSERT [dbo].[Colegios] ON 

INSERT [dbo].[Colegios] ([Id], [Nombre], [Direccion], [Email]) VALUES (7, N'bolivar', N'calle falsa', N'emaildecolegio')
SET IDENTITY_INSERT [dbo].[Colegios] OFF
SET IDENTITY_INSERT [dbo].[Colegios_Ciudades_Turnos] ON 

INSERT [dbo].[Colegios_Ciudades_Turnos] ([Id], [ColegioId], [CiudadId], [TurnoId]) VALUES (1, 7, 4, 1)
SET IDENTITY_INSERT [dbo].[Colegios_Ciudades_Turnos] OFF
SET IDENTITY_INSERT [dbo].[Contactos] ON 

INSERT [dbo].[Contactos] ([Id], [PersonaId]) VALUES (1, 11)
SET IDENTITY_INSERT [dbo].[Contactos] OFF
SET IDENTITY_INSERT [dbo].[Departamentos] ON 

INSERT [dbo].[Departamentos] ([Id], [Nombre]) VALUES (7, N'Tarija')
SET IDENTITY_INSERT [dbo].[Departamentos] OFF
SET IDENTITY_INSERT [dbo].[Directores] ON 

INSERT [dbo].[Directores] ([Id], [PersonaId]) VALUES (2, 10)
SET IDENTITY_INSERT [dbo].[Directores] OFF
SET IDENTITY_INSERT [dbo].[Permisos] ON 

INSERT [dbo].[Permisos] ([Id], [Descripcion]) VALUES (1, N'ADMIN')
SET IDENTITY_INSERT [dbo].[Permisos] OFF
SET IDENTITY_INSERT [dbo].[Personas_con_Accesos] ON 

INSERT [dbo].[Personas_con_Accesos] ([Id], [PersonaId]) VALUES (7, 7)
INSERT [dbo].[Personas_con_Accesos] ([Id], [PersonaId]) VALUES (9, 11)
INSERT [dbo].[Personas_con_Accesos] ([Id], [PersonaId]) VALUES (10, 12)
INSERT [dbo].[Personas_con_Accesos] ([Id], [PersonaId]) VALUES (11, 13)
INSERT [dbo].[Personas_con_Accesos] ([Id], [PersonaId]) VALUES (12, 14)
SET IDENTITY_INSERT [dbo].[Personas_con_Accesos] OFF
SET IDENTITY_INSERT [dbo].[Personas_Naturales] ON 

INSERT [dbo].[Personas_Naturales] ([Id], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Email], [CI], [Activo]) VALUES (7, N'Jorge Luis', N'Gutierrez', N'Fernandez', N'jorge.gutierrezf3@gmail.com', N'5054722', 1)
INSERT [dbo].[Personas_Naturales] ([Id], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Email], [CI], [Activo]) VALUES (10, N'jorge1', N'gutierrezf1', N'fernandez1', N'email1', N'5054721', 1)
INSERT [dbo].[Personas_Naturales] ([Id], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Email], [CI], [Activo]) VALUES (11, N'mathias', N'toledo', N'valverde', N'emailmathais', N'666366', 1)
INSERT [dbo].[Personas_Naturales] ([Id], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Email], [CI], [Activo]) VALUES (12, N'ni idea', NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Personas_Naturales] ([Id], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Email], [CI], [Activo]) VALUES (13, N'random', NULL, NULL, NULL, NULL, 1)
INSERT [dbo].[Personas_Naturales] ([Id], [Nombres], [Apellido_Paterno], [Apellido_Materno], [Email], [CI], [Activo]) VALUES (14, N'jorge', N'artesano', N'marquez', N'j.guty0612@gmail.com', N'10101', 1)
SET IDENTITY_INSERT [dbo].[Personas_Naturales] OFF
SET IDENTITY_INSERT [dbo].[Provincias] ON 

INSERT [dbo].[Provincias] ([Id], [Nombre], [DepartamentoId]) VALUES (5, N'Gran Chaco', 7)
SET IDENTITY_INSERT [dbo].[Provincias] OFF
SET IDENTITY_INSERT [dbo].[Turnos] ON 

INSERT [dbo].[Turnos] ([Id], [Descripcion], [Activo], [DirectorId], [ContactoId]) VALUES (1, N'Tarde', 1, 2, 1)
SET IDENTITY_INSERT [dbo].[Turnos] OFF
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [UserId], [Password], [PermisoId], [PersonaId]) VALUES (1, N'j.guty06', N'8ut4vPXA5rf7beMzmPm6fQ==', 1, 7)
INSERT [dbo].[Usuarios] ([Id], [UserId], [Password], [PermisoId], [PersonaId]) VALUES (2, N'mathias01', N'P7zve9cfhxlR6Td0OgiGug==', 1, 9)
INSERT [dbo].[Usuarios] ([Id], [UserId], [Password], [PermisoId], [PersonaId]) VALUES (3, N'usuario2', N'ACegfyq6Kh2dG6vW7fwZ9jwbyTdsz3kSL+ZH3LS5YTo=', 1, 12)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[Telefonos] ADD  DEFAULT ((0)) FOR [Activo]
GO
ALTER TABLE [dbo].[Universidades] ADD  DEFAULT ((0)) FOR [Activo]
GO
ALTER TABLE [dbo].[Alumnos]  WITH CHECK ADD  CONSTRAINT [FK__Alumnos__Persona__1FCDBCEB] FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Personas_Naturales] ([Id])
GO
ALTER TABLE [dbo].[Alumnos] CHECK CONSTRAINT [FK__Alumnos__Persona__1FCDBCEB]
GO
ALTER TABLE [dbo].[Ciudades]  WITH CHECK ADD  CONSTRAINT [FK__Ciudades__Provin__3D5E1FD2] FOREIGN KEY([ProvinciaId])
REFERENCES [dbo].[Provincias] ([Id])
GO
ALTER TABLE [dbo].[Ciudades] CHECK CONSTRAINT [FK__Ciudades__Provin__3D5E1FD2]
GO
ALTER TABLE [dbo].[Clasificacion_Tipos]  WITH CHECK ADD FOREIGN KEY([DetalleId])
REFERENCES [dbo].[Tipos_Detalles] ([Id])
GO
ALTER TABLE [dbo].[Colegios_Ciudades_Turnos]  WITH CHECK ADD  CONSTRAINT [FK__Colegios___Ciuda__44FF419A] FOREIGN KEY([CiudadId])
REFERENCES [dbo].[Ciudades] ([Id])
GO
ALTER TABLE [dbo].[Colegios_Ciudades_Turnos] CHECK CONSTRAINT [FK__Colegios___Ciuda__44FF419A]
GO
ALTER TABLE [dbo].[Colegios_Ciudades_Turnos]  WITH CHECK ADD FOREIGN KEY([ColegioId])
REFERENCES [dbo].[Colegios] ([Id])
GO
ALTER TABLE [dbo].[Colegios_Ciudades_Turnos]  WITH CHECK ADD FOREIGN KEY([TurnoId])
REFERENCES [dbo].[Turnos] ([Id])
GO
ALTER TABLE [dbo].[Contactos]  WITH CHECK ADD FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Personas_con_Accesos] ([Id])
GO
ALTER TABLE [dbo].[Cursos_Alumnos]  WITH CHECK ADD  CONSTRAINT [FK__Cursos_Al__Alumn__403A8C7D] FOREIGN KEY([AlumnoId])
REFERENCES [dbo].[Alumnos] ([Id])
GO
ALTER TABLE [dbo].[Cursos_Alumnos] CHECK CONSTRAINT [FK__Cursos_Al__Alumn__403A8C7D]
GO
ALTER TABLE [dbo].[Cursos_Alumnos]  WITH CHECK ADD FOREIGN KEY([Cursos])
REFERENCES [dbo].[Cursos] ([Id])
GO
ALTER TABLE [dbo].[Detalle_Alumnos]  WITH CHECK ADD  CONSTRAINT [FK__Detalle_A__Alumn__48CFD27E] FOREIGN KEY([AlumnoId])
REFERENCES [dbo].[Alumnos] ([Id])
GO
ALTER TABLE [dbo].[Detalle_Alumnos] CHECK CONSTRAINT [FK__Detalle_A__Alumn__48CFD27E]
GO
ALTER TABLE [dbo].[Detalle_Alumnos]  WITH CHECK ADD FOREIGN KEY([ClasificacionId])
REFERENCES [dbo].[Clasificacion_Tipos] ([Id])
GO
ALTER TABLE [dbo].[Directores]  WITH CHECK ADD FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Personas_con_Accesos] ([Id])
GO
ALTER TABLE [dbo].[Personas_con_Accesos]  WITH CHECK ADD FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Personas_Naturales] ([Id])
GO
ALTER TABLE [dbo].[Provincias]  WITH CHECK ADD FOREIGN KEY([DepartamentoId])
REFERENCES [dbo].[Departamentos] ([Id])
GO
ALTER TABLE [dbo].[Telefonos_Personas]  WITH CHECK ADD FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Personas_Naturales] ([Id])
GO
ALTER TABLE [dbo].[Telefonos_Personas]  WITH CHECK ADD FOREIGN KEY([TelefonoId])
REFERENCES [dbo].[Telefonos] ([Id])
GO
ALTER TABLE [dbo].[Telefonos_Turnos]  WITH CHECK ADD FOREIGN KEY([TelefonoId])
REFERENCES [dbo].[Telefonos] ([Id])
GO
ALTER TABLE [dbo].[Telefonos_Turnos]  WITH CHECK ADD FOREIGN KEY([TurnoId])
REFERENCES [dbo].[Turnos] ([Id])
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD FOREIGN KEY([ContactoId])
REFERENCES [dbo].[Contactos] ([Id])
GO
ALTER TABLE [dbo].[Turnos]  WITH CHECK ADD FOREIGN KEY([DirectorId])
REFERENCES [dbo].[Directores] ([Id])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([PermisoId])
REFERENCES [dbo].[Permisos] ([Id])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([PersonaId])
REFERENCES [dbo].[Personas_con_Accesos] ([Id])