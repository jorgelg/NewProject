using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject.Models
{
    public class Personas_Naturales
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nombre: ")]
        [DataType(DataType.Text)]
        public string Nombres { get; set; }

        [Display(Name ="Apellido Paterno: ")]
        [DataType(DataType.Text)]
        public string Apellido_Paterno { get; set; }

        [Display(Name = "Apellido Materno: ")]
        [DataType(DataType.Text)]
        public string Apellido_Materno { get; set; }

        [Display(Name ="Email: ")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name ="CI: ")]
        [DataType(DataType.Text)]
        public string CI { get; set; }

        public bool Activo { get; set; }
    }
}
