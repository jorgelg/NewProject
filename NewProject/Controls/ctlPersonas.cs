using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewProject.Models;
namespace NewProject.Controls
{
    public class ctlPersonas
    {
        Personas_Naturales persona;
        public ctlPersonas()
        {
            persona = new Personas_Naturales();
        }

        public int RegistrarPersona(string nombre,string ap, string am, string email, string ci)
        {
            using (var db = new DBServices.PeopleDBContext())
            {
                persona=db.Personas.Create();
                persona.Activo = true;
                persona.Nombres = nombre;
                persona.Apellido_Paterno = ap;
                persona.Apellido_Materno = am;
                persona.Email = email;
                persona.CI = ci;
                db.Personas.Add(persona);
                db.SaveChanges();
                return persona.Id;
            }
        }


    }
}
