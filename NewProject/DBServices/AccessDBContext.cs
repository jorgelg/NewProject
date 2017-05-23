using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using NewProject.Models;
namespace NewProject.DBServices
{
    public class AccessDBContext:DbContext
    {
        public AccessDBContext()
            :base("name=BDLOCAL")
        {

        }

        public DbSet<Permisos> Permisos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Personas_con_Accesos> Personas_con_Accesos { get; set; }
        public DbSet<Personas_Naturales> Personas_Naturales { get; set; }
    }
}
