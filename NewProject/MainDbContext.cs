using NewProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace NewProject
{
    public class MainDbContext:DbContext
    {
        public MainDbContext()
            : base("name=BDLOCAL")
        {

        }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Provincias> Provincias { get; set; }
        public DbSet<Ciudades> Ciudades { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<Colegios> Colegios { get; set; }
        public DbSet<Universidades> Universidades { get; set; }
        public DbSet<Telefonos> Telefonos { get; set; }
        public DbSet<Turnos> Turnos { get; set; }

        public DbSet<Tipos_Detalles> Tipos_Detalles { get; set; }
        public DbSet<Clasificacion_Tipos> Clasificacion_Tipos { get; set; }

        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Personas_Naturales> Personas_Naturales { get; set; }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Personas_con_Accesos> Personas_con_Accesos { get; set; }
        
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Contactos> Contactos { get; set; }
        public DbSet<Directores> Directores { get; set; }

        //public DbSet<Telefonos_Personas> Telefonos_Personas { get; set; }
        //public DbSet<Formularios> Formularios { get; set; }
        
        public DbSet<Cursos_Alumnos> Cursos_Alumnos { get; set; }
        public DbSet<Colegios_Ciudades_Turnos> Colegios_Ciudades_Turnos { get; set; }
        public DbSet<Detalles_Alumnos> Detalles_Alumnos { get; set; }
        public DbSet<Telefonos_Personas> Telefonos_Personas { get; set; }
        public DbSet<Telefonos_Turnos> Telefonos_Turnos { get; set; }
    }
}
