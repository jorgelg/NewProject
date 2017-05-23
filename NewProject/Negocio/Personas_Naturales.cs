using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Negocio
{
    public class Personas_Naturales
    {
        public string Nombres;
        public string Apellido_Paterno;
        public string Apellido_Materno;
        public string Email;
        public string CI;
        public bool Activo;

        public Personas_Naturales()
        {

        }

        public Personas_Naturales(string nombre,string app, string apm,string email,string ci)
        {
            Nombres = nombre;
            Apellido_Paterno = app;
            Apellido_Materno = apm;
            this.Email = email;
            this.CI = ci;
            Activo = true;
        }
        public Personas_Naturales getInstance()
        {
            return this;
        }
    }
}
