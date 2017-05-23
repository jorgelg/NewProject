using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Usuario ")]
        [DataType(DataType.Text)]
        public string UserId { get; set; }
        
        [Required]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [ForeignKey("Personas_con_Accesos"),Column(Order =0)]
        public int PersonaId { get; set; }

        [ForeignKey("Permisos"),Column(Order =1)]
        public int PermisoId { get; set; }

        public virtual Personas_con_Accesos Personas_con_Accesos { get; set; }

        public virtual Permisos Permisos { get; set; }
    }
}
