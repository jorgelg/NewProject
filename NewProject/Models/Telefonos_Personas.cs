using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewProject.Models
{
    public class Telefonos_Personas
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Personas_Naturales"),Column(Order =0)]
        public int PersonaId { get; set; }

        [ForeignKey("Telefonos"),Column(Order =1)]
        public int TelefonoId { get; set; }

        public virtual Personas_Naturales Personas_Naturales { get; set; }
        public virtual Telefonos Telefonos { get; set; }

        //public virtual ICollection<Student> Students { get; set; }
    }
}
