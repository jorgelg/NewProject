using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Formularios
    {
        public string Nombre { get; set; }
        public string Apellido_Paterno { get; set; }
        public string Apellido_Materno { get; set; }
        public string CI { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Colegio { get; set; }
        public string Curso { get; set;}
        public string Carrera { get; set; }
    }
}
