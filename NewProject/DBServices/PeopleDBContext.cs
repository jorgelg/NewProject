using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NewProject.Models;
namespace NewProject.DBServices
{
    public class PeopleDBContext
        : DbContext
    {
        public PeopleDBContext()
            : base("name=BDLOCAL")
        {

        }

        public DbSet<Personas_Naturales> Personas { get; set; }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Personas_con_Accesos> Personas_con_Acceso { get; set; }
        public DbSet<Directores> Directores { get; set; }
        public DbSet<Contactos> Contactos { get; set; }
        //pendiente estudiantes y personal academico...
    }
}
